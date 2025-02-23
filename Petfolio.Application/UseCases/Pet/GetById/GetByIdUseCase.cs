using Petfolio.Communication.Response;

namespace Petfolio.Application.UseCases.Pet.GetById;
public class GetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "totó",
            Birthday = new DateTime(year: 2010, month: 10, day: 10),
            Type = Communication.Enum.PetType.Dog
        };
    }
}
