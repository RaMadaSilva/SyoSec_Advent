using Flunt.Notifications;
using Flunt.Validations;

namespace SyosecAdvent.Application.Recommendations.Create
{
    public  static class ValidationCreateRequest
    {
        public static Contract<Notification> Ensure(CreateRequest request)
            => new Contract<Notification>()
                   .Requires()
                   .IsGreaterThan(request.FirstName.Length, 2, "FistName", "O Nome deve ter mais que 2 caracteres")
                   .IsGreaterThan(request.LastName.Length, 2,"LastName", "O sobre Nome deve ter mais que 2 caracteres")
                   .IsGreaterThan(request.Phone.Length, 8, "Phone", "deve ter 9 Numeros")
                   .IsGreaterThan(request.Street.Length, 5, "Street", "Nome da rua deve conter mais de 5 caracteres")
                   .IsGreaterThan(request.City.Length, 5, "City", "Nome da Cidade deve conter mais de 5 caracteres")
                   .IsGreaterThan(request.Province.Length, 2, "Province", "Nome da Provincia do Membro deve conter mais de 2 caracteres")
                   .IsGreaterThan(request.ChurchName.Length, 4, "ChurchName", "O Nome da Igreja ter mais que 4 caracteres")
                   .IsGreaterThan(request.ChurchStreet.Length, 5, "ChurchStreet", "O Nome da rua da Igreja  deve ter mais que 5 caracteres")
                   .IsGreaterThan(request.ChurchCity.Length, 5, "ChurchCity", "O  Nome da cidade da Igreja deve contar mais de 5 caracteres")
                   .IsGreaterThan(request.ChurchProvince.Length, 2, "ChurchProvince", "Nome da Provincia da Igreja deve conter mais de 2 caracteres")
                   .IsLowerThan(request.Observation.Length, 500, "Observation", "A Observação não deve ter mas de 500 caracteres");
    }
}
