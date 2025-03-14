using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session01Assignment.Entities;

namespace Session03Assignment.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Adress { get; set; }
        public decimal HourRate { get; set; }


        #region Relationships
        // many to many =>  instructor teach courses
        public ICollection<Course_Inst> InstCourses { get; set; } = new HashSet<Course_Inst>();

        // one to one => Instructor may manage Department
        // navigational property
        [InverseProperty("Manager")]
        public Department? ManagedDepartment { get; set; }

        // one to many => instructors have departments

        [InverseProperty("Instructors")] 
        public Department Department { get; set; } // Navigation property*/
        #endregion
    }
}
