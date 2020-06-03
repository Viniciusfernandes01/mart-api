using Mart.API.Domain.Repositories;
using Mart.API.Domain.Services;
using Mart.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mart.API.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<IEnumerable<Product>> ListAsync()
        {
            return _productRepository.ListAsync();
        }
    }
}
