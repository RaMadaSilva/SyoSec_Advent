using MediatR;
using SyosecAdvent.Application.Common;
using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Domain.ValueObjects;

namespace SyosecAdvent.Application.UseCase.Recommendations.Create
{
    public class CreateHandler : IRequestHandler<CreateRequest, CreateResponse>
    {
        private readonly IUnitOfWorkAsync _uow;

        public CreateHandler(IUnitOfWorkAsync uow) =>_uow = uow;

        public async Task<CreateResponse> Handle(CreateRequest request, CancellationToken cancellationToken)
        {
            Name name;
            Member member;
            Address addressMember;
            Address addressChurch;
            Church church;
            Recommendation recommendation = null;

            try
            {
                var val = ValidationCreateRequest.Ensure(request);
                if (!val.IsValid)
                    return new CreateResponse("Não foi possivel criar a recommendacao", 400, val.Notifications);
            }
            catch (Exception ex)
            {
                return new CreateResponse(ex.Message, 500);
            }

            try
            {
                name = new Name(request.FirstName, request.LastName);
                addressMember = new Address(request.Street, request.City, request.Province);
                member = new Member(name, request.Phone, addressMember);

                addressChurch = new Address(request.ChurchStreet, request.ChurchCity, request.ChurchProvince);
                church = new Church(request.ChurchName, addressChurch);

                var membrBd = await _uow
                                    .MemberReadRepository
                                    .GetMemberByNameAsync(name);
                var churchBd = await _uow
                                .ChurchReadRepository
                                .GetChurchByNameAsync(request.ChurchName);

                if (membrBd.Equals(member) && churchBd.Equals(church))
                {
                    recommendation = new Recommendation(membrBd,
                                            churchBd,
                                            request.Observation,
                                            request.RecommendationType);

                    await _uow.RecommendationWriteRepository.AddAsync(recommendation);
                }
                else if (membrBd.Equals(member) && !churchBd.Equals(church))
                {
                    recommendation = new Recommendation(membrBd,
                        church,
                        request.Observation,
                        request.RecommendationType);

                    await _uow.ChurchWriteRepository.AddAsync(church);
                    await _uow.RecommendationWriteRepository.AddAsync(recommendation);
                }
                else if (!membrBd.Equals(member) && churchBd.Equals(church))
                {
                    recommendation = new Recommendation(member,
                        churchBd,
                        request.Observation,
                        request.RecommendationType);
                    await _uow.MemberWriteRepository.AddAsync(member);
                    await _uow.RecommendationWriteRepository.AddAsync(recommendation);

                }
                else if (!membrBd.Equals(member) && !churchBd.Equals(church))
                {
                    recommendation = new Recommendation(member,
                        church,
                        request.Observation,
                        request.RecommendationType);

                    await _uow.ChurchWriteRepository.AddAsync(church);
                    await _uow.MemberWriteRepository.AddAsync(member);
                    await _uow.RecommendationWriteRepository.AddAsync(recommendation);

                }

                await _uow.CommitAsync(cancellationToken);

                var data = new DataRecommendationResponse(recommendation.Id,
                        recommendation.Member.NameMember.ToString(),
                        recommendation.Church.NameChurch,
                        Enum.GetName(recommendation.RecommendationType));

                return new CreateResponse("Recomendação criada com sucesso", data);
            }
            catch (Exception ex)
            {
                return new CreateResponse(ex.Message, 500);
            }
        }
    }
}