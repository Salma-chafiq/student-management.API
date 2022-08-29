using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using student_manager.API.DomainModels;
using student_manager.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace student_manager.API.Controllers
{
    
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //les injection
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public StudentsController( IStudentRepository studentRepository, IMapper mapper )
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult>GetAllStudents()
        {
           var students = await studentRepository.GetStudentsAsync();

            return Ok(mapper.Map<List<Student>>(students));
           /* 
            * Sans automapper
            var domainModelsStudents = new List<Student>();
            foreach (var student in students)
            {
                domainModelsStudents.Add(new Student()
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    DateOfBirth=student.DateOfBirth,
                    Email =student.Email,
                    Mobil=student.Mobil,
                    ProfileImageUrl=student.ProfileImageUrl,
                    GenderId=student.GenderId,
                    Adress=new Adress
                    {
                        Id = student.Adress.Id,
                        PhysicalAddress = student.Adress.PhysicalAddress,
                        PostalAddress = student.Adress.PhysicalAddress
                    },
                    Gender =new Gender()
                    {
                        Id =student.Gender.Id,
                        Description=student.Gender.Description
                    }

                }) ;
            }*/
         
        }
    }
}
