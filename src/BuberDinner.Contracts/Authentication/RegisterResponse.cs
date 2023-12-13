using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuberDinner.Contracts.Authentication
{
    public record RegisterResponse(
     string Message,
     string Email,
     string FirstName,
     string LastName
   );
}