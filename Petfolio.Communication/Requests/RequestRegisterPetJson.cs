using Petfolio.Communication.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petfolio.Communication.Requests;
public class RequestRegisterPetJson
{
    public string Name { get; set; } = string.Empty;
    public DateTime Birthday { get; set; }
    public PetType Type { get; set; }
}
