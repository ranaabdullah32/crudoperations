using crudoperations.Models;

namespace crudoperations.Services
{
    public static class StudentService
    {
        private static List<StudentModel> _students = new List<StudentModel>();

        public static List<StudentModel> GetAll()
        {
            return _students;

        }
        public static StudentModel GetbyId(int id)
        {
            StudentModel student = null;
            foreach (StudentModel sid in _students)
            {

                if (sid.Id == id)
                {
                    student = sid;
                    break;
                }
            }
            return student;
        }

        public static void Add(StudentModel model)
        {
            _students.Add(model);
        }
        public static List<StudentModel> Delete(int id)
        {
            foreach(StudentModel sid in _students)
            {

                if (sid.Id == id)
                {
                    _students.Remove(sid);
                    break;
                }
            }
            return _students;
        }
        public static List<StudentModel> Update(StudentModel tempmodel)
        {
            foreach(StudentModel sid in _students)
            {
                if(sid.Id == tempmodel.Id)
                {
                    sid.Name = tempmodel.Name;
                    sid.Email = tempmodel.Email;
                }
            }
            return _students;
        }
    }
}
