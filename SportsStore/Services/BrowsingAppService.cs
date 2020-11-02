using SportsStore.Domain.Db;
using SportsStore.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Services
{
    public class BrowsingAppService : IBrowsingAppService
    {
        SportsStoreDbContext _dbContext;

        public BrowsingAppService(SportsStoreDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public GetCategoriesResponse GetCategories(GetCategoriesRequest request)
        {
            throw new NotImplementedException();
        }

        public GetProductsResponse GetProducts(GetProductsRequest request)
        {
            var filteredProducts = _dbContext.Products
                .Where(p => p.Category.Name == request.CategoryName || request.CategoryName == null);

            var totalCount = filteredProducts.Count();

            var result = filteredProducts
                .Skip(request.PageSize * (request.Page - 1))
                .Take(request.PageSize)
                .Select(p => new GetProductsResponse.Product
                {
                    Name = p.Name,
                    ProductId = p.ProductId,
                    Price = p.Price,
                    ThumbnailUrl = p.Images.SingleOrDefault(i => i.IsThumbnail).ImageUrl
                });
            
            return new GetProductsResponse
            {
                Products = result.ToList(),
                TotalCount = totalCount
            };
        }
    }
}
