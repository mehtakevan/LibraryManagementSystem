using LIBMGMT.Models;

namespace LIBMGMT.Interfaces
{
    public interface IAuthors
    {
        public Task<List<Author>> Index();
    }
}
