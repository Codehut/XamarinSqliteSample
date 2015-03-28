using System;
using SQLite.Net.Attributes;

namespace XamarinSqliteSample
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Student()
        {
        }
    }
}
