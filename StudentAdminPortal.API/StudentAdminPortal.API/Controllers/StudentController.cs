using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.API.DataModels;
using StudentAdminPortal.API.Models;
using StudentAdminPortal.API.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Controllers
{
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;
        public StudentController(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;   
        }

        [HttpGet]
        [Route("[Controller]")]
        public async Task< IActionResult> GetAllStudents()
        {
            var students = await _studentRepository.GetStudents();



            var dtoStudents = _mapper.Map<List<StudentDto>>(students);

            return Ok(dtoStudents);
        }
    }
}
