using LIBMGMT.Interfaces;
using LIBMGMT.Models;
using Microsoft.EntityFrameworkCore;
namespace LIBMGMT.Repositories
{
    public class StudentRepository : IStudent
    {
        private readonly LibraryDbContext _context;

        public StudentRepository(LibraryDbContext context)
        {
            _context = context;
        }
        //implementing using DbContext for GET-METHOD
        public Task<List<Student>> Index()
        {
            return _context.Students.ToListAsync();
        }
    }
}
