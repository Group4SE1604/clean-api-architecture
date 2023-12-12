using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuberDinner.Application.Common.Services
{
    public interface IDatetimeProivder
    {
        DateTime UtcNow { get; }

    }
}