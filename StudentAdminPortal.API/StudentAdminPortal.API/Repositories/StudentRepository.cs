using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.API.DataModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext _context;
        public StudentRepository(StudentAdminContext context)
        {
            _context = context;
        }


        public async Task<List<Student>> GetStudents()
        {
            return await _context.Students.Include(nameof(Gender)).Include(nameof(Adress)).ToListAsync();
        }
    }
}
