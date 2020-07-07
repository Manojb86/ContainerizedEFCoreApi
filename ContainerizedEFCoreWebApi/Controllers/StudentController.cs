using ContainerizedEFCoreWebApi.Data.DatabaseContext;
using ContainerizedEFCoreWebApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContainerizedEFCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AcademicContext acadamicContext;
        public StudentController(AcademicContext acadamicContext)
        {
            this.acadamicContext = acadamicContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await acadamicContext.Students.ToListAsync();
        }
    }
}