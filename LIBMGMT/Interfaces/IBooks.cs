using LIBMGMT.Models;
namespace LIBMGMT.Interfaces
{
    public interface IBooks
    {
        //get-books
        public Task<List<Book>> Index();
    }
}
