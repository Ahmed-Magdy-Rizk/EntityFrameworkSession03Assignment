using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Session03Assignment.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        //public int Dep_Id { get; set; }

        #region Realtionships
        // many to many => Students Take Courses
        public ICollection<Stud_Course> StudentCourses { get; set; } = new HashSet<Stud_Course>();

        // one to many => Student located in a department
        [ForeignKey(nameof(Department))]
        private int DepartmentId { get; set; }
        public Department Department { get; set; } // Navigation property


        #endregion
    }
}
