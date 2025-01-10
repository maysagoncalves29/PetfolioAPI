using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pet.Register;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Response;

namespace Petfolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredPetJson), StatusCodes.Status201Created)]
    public IActionResult Register([FromBody] ResponseRegisteredPetJson request)
    {
        var useCase = new RegisterPetUseCase();
        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }
}
