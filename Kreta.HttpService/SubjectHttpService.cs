using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models;
using Kreta.Shared.Responses;
using System.Net.Http.Json;

namespace Kreta.HttpService
{
    public class SubjectHttpService : ISubjectHttpService
    {
        private readonly HttpClient _httpClient;

        public SubjectHttpService()
        {
            _httpClient = new HttpClient();
        }
        public SubjectHttpService(IHttpClientFactory? httpClientFactory)
        {
            if (httpClientFactory == null) throw new ArgumentNullException(nameof(httpClientFactory));
            _httpClient = httpClientFactory.CreateClient("KretaApi");
        }
        public Task<Response> CreateAsync(Student student)
        {
            throw new NotImplementedException();
        }

        public Task<Response> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Student>> GetAllAsync()
        {
            try
            {
                List<StudentDto>? resultDto = await _httpClient.GetFromJsonAsync<List<StudentDto>>("api/Student");
                if (resultDto != null)
                    return resultDto.Select(dto => dto.ToStudent()).ToList();
            }
            catch (Exception ex)
            {
            }
            return new List<Student>();
        }

        public Task<Student> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdateAsync(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
