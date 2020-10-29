using SportsStore.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Services
{
    public interface IBrowsingAppService
    {
        public GetCategoriesResponse GetCategories(GetCategoriesRequest request);

        public GetProductsResponse GetProducts(GetProductsRequest request);
    }
}
