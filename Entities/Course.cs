using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session01Assignment.Entities;

namespace Session03Assignment.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public decimal Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public int Top_ID { get; set; }

        #region Realtionships
        // many to many =>  Courses Taken by Students
        public ICollection<Stud_Course> StudentCourses { get; set; } = new HashSet<Stud_Course>();

        // many to many =>  Courses taugh by instructor
        public ICollection<Course_Inst> InstCourses { get; set; } = new HashSet<Course_Inst>();

        // one to many => courses classify topic
        [ForeignKey(nameof(Topic))]
        public int TopicId { get; set; }
        public Topic Topic { get; set; } // Navigation property
        #endregion
    }
}
