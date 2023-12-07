using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuberDinner.Application.Common.Interfaces.Auth
{
    public interface IJwtGenerator
    {
        string GenrateToken(Guid userId, string firstName, string lastName);
    }
}