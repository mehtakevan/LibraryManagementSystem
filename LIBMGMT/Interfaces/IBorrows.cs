using LIBMGMT.Models;
namespace LIBMGMT.Interfaces
{
    public interface IBorrows
    {
        //get-borrow details
        public Task<List<Borrow>> Index();
    }
}
