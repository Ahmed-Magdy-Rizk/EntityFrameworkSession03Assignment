using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Session03Assignment.Entities
{
    [PrimaryKey(nameof(Stud_ID), nameof(Course_ID))]
    internal class Stud_Course
    {
        [ForeignKey(nameof(Student))]
        public int Stud_ID { get; set; }
        [ForeignKey(nameof(Course))]
        public int Course_ID { get; set; }
        public decimal? Grade { get; set; }

        #region Realtionships
        // many to many 
        public Student Student { get; set; }

        public Course Course { get; set; }
        #endregion
    }
}
