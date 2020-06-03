using Mart.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mart.API.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
