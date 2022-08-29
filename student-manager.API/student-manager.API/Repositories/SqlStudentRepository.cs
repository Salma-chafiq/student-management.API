using Microsoft.EntityFrameworkCore;
using student_manager.API.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace student_manager.API.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentContext context;

        public SqlStudentRepository(StudentContext context)
        {
            this.context = context;
        }
        public async  Task<List<Student>> GetStudentsAsync()
        {
            return await context.Student.Include(nameof(Gender)).Include(nameof(Adress)).ToListAsync();
        }
    }
}
