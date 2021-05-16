using SchoolSytemEntities;
using System.Threading.Tasks;

namespace SchoolSystemDataAccessLayer
    {
    public interface ITeacherDAL
        {

        public Task<bool> AddTeacher(Teacher teacher);
        public Task<bool> DeleteTeacher(int id);
        }
    }
