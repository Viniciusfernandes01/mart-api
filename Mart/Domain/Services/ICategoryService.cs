using Mart.API.Domain.Services.Communication;
using Mart.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mart.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);
    }
}
