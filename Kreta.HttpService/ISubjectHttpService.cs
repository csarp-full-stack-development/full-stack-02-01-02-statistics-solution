using Kreta.Shared.Models;
using Kreta.Shared.Responses;

namespace Kreta.HttpService
{
    public interface ISubjectHttpService
    {
        Task<List<Student>> GetAllAsync();
        Task<Student> GetByIdAsync(Guid id);
        Task<Response> CreateAsync(Student student);
        Task<Response> UpdateAsync(Student student);
        Task<Response> DeleteAsync(Guid id);
    }
}
