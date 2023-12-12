using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Application.Common.Services;

namespace BuberDinner.Infrastructure.Services
{
    public class DatetimeProvider : IDatetimeProivder
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}