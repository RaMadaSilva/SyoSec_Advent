using MediatR;
using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Domain.ValueObjects;

namespace SyosecAdvent.Application.Recommendations.Create
{
    public class Handler : IRequestHandler<Request, CreateResponse>
    {
        private readonly IUnitOfWorkAsync _uow;

        public Handler(IUnitOfWorkAsync uow)
        {
            _uow = uow;
        }

        public async Task<CreateResponse> Handle(Request request, CancellationToken cancellationToken)
        {
            try
            {
                var val = ValidationRequest.Ensure(request);
                if (!val.IsValid)
                    return new CreateResponse("Não foi possivel criar a recommendacao", 400, val.Notifications); 

            }catch (Exception ex)
            {
                return new CreateResponse(ex.Message, 500); 
            }
            try
            {
                var name = new Name(request.FirstName, request.LastName);
                var addressMember = new Address(request.Street, request.City, request.Province);
                var member = new Member(name, request.Phone, addressMember);

                var churchAddress = new Address(request.ChurchStreet, request.ChurchCity, request.ChurchProvince);
                var church = new Church(request.ChurchName, churchAddress);

                var recommendation = new Recommendation(member, church, request.Observation, request.RecommendationType); 

                //TODO: Verificar se Exite um membro igual
                var membrBd = await _uow
                                    .MemberReadRepository
                                    .GetMemberByNameAsync(name);
                //TODO: Caso Exista vamos apenas adicionar a recommendação ao membro
                if (membrBd.Equals(member))
                {
                    //TODO: Implementar a logica aqui
                }
                //TODO: Caso não Exista vamos salvar o membro no banco adicionar a recommendação
                await _uow.MemberWriteRepository.AddAsync(member);

                //TODO: Verificar se A Igreja Existe no banco

                var churchBd = _uow
                                .ChurchReadRepository
                                .GetChurchByNameAsync(request.ChurchName);
                //TODO: Caso exista vamos apenas adionar a recommendação a igreja 
                if (churchBd.Equals(church))
                {
                    //TODO Colocar uma Logica aqui 
                }
                //TODO: Caso não Exista vamos salvar a igreja no banco adicionar a recommendação 
                await _uow.ChurchWriteRepository.AddAsync(church); 
                await _uow.RecommendationWriteRepository.AddAsync(recommendation);
                await _uow.CommitAsync(cancellationToken);

                var data = new CreateRecommendationData(recommendation.Id, 
                        recommendation.Member.NameMember.ToString(),
                        recommendation.Church.NameChurch, 
                        Enum.GetName(recommendation.RecommendationType));

                return new CreateResponse(data, "Recomendação criada com sucesso"); 
            }
            catch (Exception ex)
            {
                return new CreateResponse(ex.Message, 500); 
            }
        }
    }
}
