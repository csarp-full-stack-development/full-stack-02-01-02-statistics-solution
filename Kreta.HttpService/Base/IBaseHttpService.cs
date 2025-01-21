using Kreta.Shared.Models;
using Kreta.Shared.Responses;

namespace Kreta.HttpService.Base
{
    public interface IBaseHttpService<TModel>
    {
        Task<List<TModel>> GetAllAsync();
        Task<TModel> GetByIdAsync(Guid id);
        Task<Response> CreateAsync(TModel student);
        Task<Response> UpdateAsync(TModel student);
        Task<Response> DeleteAsync(Guid id);
    }
}
