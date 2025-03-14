using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session03Assignment.Entities;

namespace Session01Assignment.Entities
{
    internal class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }

        #region Realtionships
        // one to many =>  Topic Classify Courses
        public ICollection<Course>? Course { get; set; } = new HashSet<Course>();
        #endregion
    }
}
