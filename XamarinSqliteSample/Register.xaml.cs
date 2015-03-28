using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinSqliteSample
{
    public partial class Register : ContentPage
    {
        public StudentDB _studentdb;
        public Student student;
        public Register()
        {
            InitializeComponent();
        }

        public void adddata(object s, EventArgs args)
        {
            student = new Student();
            _studentdb = new StudentDB();
            student.Name = name.Text;
            student.Address = address.Text;
            student.Phone = phone.Text;
            _studentdb.AddStusent(student);
        }

        public void Showdata(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new StudentList());
        }
    }
}
