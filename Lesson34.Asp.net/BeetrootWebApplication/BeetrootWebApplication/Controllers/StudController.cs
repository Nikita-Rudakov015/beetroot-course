using BeetrootWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeetrootWebApplication.Controllers
{
    [Route("student")]
    public class StudController : Controller
    {
        [HttpGet("{id}")]
        public IActionResult Index([FromRoute] int id)
        {
            var student = Storage<StudentModel>.Instance.Get(id);

            return View(student);
        }

        [HttpGet("list")]
        public IActionResult Index()
        {
            IEnumerable<StudentModel> students = Storage<StudentModel>.Instance.GetAll();

            return View("List", students);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(StudentModel model)
        {
            Storage<StudentModel>.Instance.Add(new StudentModel()
            {
                FirstName = "Serhii",
                LastName = "Olefir"
            });
            Storage<StudentModel>.Instance.Add(new StudentModel()
            {
                FirstName = "Nikita",
                LastName = "Rudakov"
            });
            return View(model);
        }
    }
}