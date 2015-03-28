using System.Collections.Generic;
using System.Linq;
using SQLite.Net;
using Xamarin.Forms;

namespace XamarinSqliteSample
{
    public class StudentDB
    {
        private SQLiteConnection _sqlconnection;

        public StudentDB()
        {
            //Getting conection and Creating table
            _sqlconnection = DependencyService.Get<ISQLite>().GetConnection();
            _sqlconnection.CreateTable<Student>();
        }

        //Get all students
        public IEnumerable<Student> GetStudents()
        {
            return (from t in _sqlconnection.Table<Student>() select t).ToList();
        }

        //Get specific student
        public Student GetStudent(int id)
        {
            return _sqlconnection.Table<Student>().FirstOrDefault(t => t.Id == id);
        }

        //Delete specific student
        public void DeleteStudent(int id)
        {
            _sqlconnection.Delete<Student>(id);
        }

        //Add new student to DB
        public void AddStusent(Student student)
        {
            _sqlconnection.Insert(student);
        }
    }
}
