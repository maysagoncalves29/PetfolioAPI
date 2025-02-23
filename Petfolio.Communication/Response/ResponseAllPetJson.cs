using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petfolio.Communication.Response;
public class ResponseAllPetJson
{
    public List<ResponseShortPetJson> Pets { get; set; } = [];
}
