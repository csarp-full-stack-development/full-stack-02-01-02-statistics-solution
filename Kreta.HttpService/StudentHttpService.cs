using Kreta.HttpService.Base;
using Kreta.Shared.Assemblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.HttpService
{
    public class StudentHttpService : BaseHttpService<Student, StudentDto>, IStudentHttpService
    {
        public StudentHttpService(IHttpClientFactory? httpClientFactory, StudentAssembler assambler) : base(httpClientFactory, assambler)
        {
        }

        public StudentHttpService() : base()
        {            
        }
    }
}
