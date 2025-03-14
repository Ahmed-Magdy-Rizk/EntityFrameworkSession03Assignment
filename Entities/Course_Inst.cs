using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Session03Assignment.Entities;

namespace Session01Assignment.Entities
{
    [PrimaryKey(nameof(InstructorId), nameof(Course_ID))] 
    internal class Course_Inst
    {
        [ForeignKey(nameof(Instructor))]
        public int InstructorId { get; set; }
        [ForeignKey(nameof(Course))]
        public int Course_ID { get; set; } 
        public string evaluate { get; set; }

        #region Realtionships
        // many to many 
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
        #endregion

    }
}
