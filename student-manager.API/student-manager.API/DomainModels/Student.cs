using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace student_manager.API.DomainModels
{
    public class Student
    {
        public Guid Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String Email { get; set; }
        public long Mobil { get; set; }
        public string ProfileImageUrl { get; set; }
        public Guid GenderId { get; set; }
        //Navigation Properties
        public Gender Gender { get; set; }
        public Adress Adress { get; set; }
    }
}
