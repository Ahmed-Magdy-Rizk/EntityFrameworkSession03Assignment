using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Session03Assignment.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }
        //public int Ins_ID { get; set; }

        #region Realtionships
        // one to many =>  Department has a location to Student
        public ICollection<Student>? Student { get; set; } = new HashSet<Student>();

        // one to one => Department managed by Instructor
        [ForeignKey(nameof(Manager))]
        public int ManagerId { get; set; } // Foreign key by convention
        [InverseProperty("ManagedDepartment")]
        public Instructor Manager { get; set; } // // navigational property

        // one to many => Department Contains many instructors
        [InverseProperty("Department")] 
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        #endregion
    }
}
