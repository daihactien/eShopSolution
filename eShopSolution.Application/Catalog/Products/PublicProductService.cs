using eShopSolution.Application.Catalog.Products.Dtos;
using eShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products
{
    internal class PublicProductService : IPublicProductService
    {
        public PagedResult<ProductViewModel> 
            GetAllByCategoryId(int categoryId, 
            int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
