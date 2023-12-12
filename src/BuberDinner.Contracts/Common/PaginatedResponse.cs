using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuberDinner.Contracts.Common
{
    public class PaginatedResponse<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPage { get; set; }
        public List<T>? Result { get; set; }

        public PaginatedResponse(int pageNumber, int pageSize, int TotalPage, List<T>? result)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.TotalPage = TotalPage;
            this.Result = result;

        }


    }
}