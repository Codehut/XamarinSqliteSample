using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinSqliteSample
{
    public partial class StudentList : ContentPage
    {
        public StudentDB _database;
        public StudentList()
        {
            InitializeComponent();

            _database = new StudentDB();
            var students = _database.GetStudents();
            StudentListView.ItemsSource = students;
        }
    }
}
