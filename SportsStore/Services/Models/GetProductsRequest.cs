using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Services.Models
{
    public class GetProductsRequest
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string CategoryName { get; set; }
    }
}
