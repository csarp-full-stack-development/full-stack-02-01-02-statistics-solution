using Kreta.Shared.Assemblers;
using Kreta.Shared.Models;
using Kreta.Shared.Responses;
using System.Net.Http.Json;

namespace Kreta.HttpService.Base
{
    public class BaseHttpService<TModel, TDto> : IBaseHttpService<TModel>
        where TModel : class, IDbEntity<TModel>, new()
        where TDto : class, new()
    {
        private readonly HttpClient _httpClient;
        private readonly Assambler<TModel, TDto> _assambler;

        private string _apiName => typeof(TModel).Name;

        public BaseHttpService()
        {
            _httpClient = new HttpClient();
        }

        public BaseHttpService(IHttpClientFactory? httpClientFactory, Assambler<TModel, TDto> assambler)
        {
            if (assambler == null) throw new ArgumentNullException(nameof(assambler));
            if (httpClientFactory == null) throw new ArgumentNullException(nameof(httpClientFactory));
            _httpClient = httpClientFactory.CreateClient("KretaApi");
            _assambler = assambler;
        }
        public Task<Response> CreateAsync(TModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<Response> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TModel>> GetAllAsync()
        {
            try
            {
                List<TDto>? resultDto = await _httpClient.GetFromJsonAsync<List<TDto>>($"api/{_apiName}");
                if (resultDto == null)
                    return new List<TModel>();
                else
                    return resultDto.Select(dto => _assambler.ToModel(dto)).ToList();
            }
            catch (Exception ex)
            {
            }
            return new List<TModel>();
        }

        public Task<TModel> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdateAsync(TModel entity)
        {
            throw new NotImplementedException();
        }
    }    
}
