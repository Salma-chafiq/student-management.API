using student_manager.API.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace student_manager.API.Repositories
{
   public interface IStudentRepository
    {
       Task<List<Student>> GetStudentsAsync();
    }
}
