using LIBMGMT.Models;
namespace LIBMGMT.Interfaces
{
    public interface IStudent
    {
        //get-students
        public  Task<List<Student>> Index();
    }
}
