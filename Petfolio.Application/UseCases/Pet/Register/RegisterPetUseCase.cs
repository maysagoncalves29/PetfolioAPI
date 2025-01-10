using Petfolio.Communication.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petfolio.Application.UseCases.Pet.Register;
public class RegisterPetUseCase
{
    public ResponseRegisteredPetJson Execute(ResponseRegisteredPetJson request)
    {
        return new ResponseRegisteredPetJson
        {
            Id = 7,
            Name = request.Name
        };
    }
}
