using Lesson34.ASP.NET_Core._MVC._WebAPI._REST.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson34.ASP.NET_Core._MVC._WebAPI._REST.Controlers
{
    [Route("[controller]")]
    public class StudentController : Controller
    {
        [HttpGet("{id}")]
        public IActionResult Index([FromRoute] int id)
        {
            var student = Storage<StudentModel>.Instance.Get(id);
            
            return View(student);
        }

        [HttpGet ("list")]
        public IActionResult Index()
        {
            var student = Storage<StudentModel>.Instance.GetAll()

            return View(student);
        }

        [HttpPost("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost ("create")]
        public IActionResult Create([FromForm] StudentModel model)
        {
            return View(model);
        }

    }
}
