using LIBMGMT.Interfaces;
using LIBMGMT.Models;
using Microsoft.EntityFrameworkCore;

namespace LIBMGMT.Repositories
{
    public class AuthorsRepository : IAuthors
    {
        private readonly LibraryDbContext _context;

        public AuthorsRepository(LibraryDbContext context)
        {
            _context = context;
        }

        //implementing using DbContext for GET-METHOD
        public async Task<List<Author>> Index()
        {
            return (await _context.Authors.ToListAsync());
        }
    }
}
