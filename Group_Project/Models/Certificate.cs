using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Group_Project.Models
{
    public class Certificate

    {
        [DisplayName("Certificate Id")]
        public int Id { get; set; }
        [DisplayName("Certificate Title")]
        public string Title { get; set; }
        public virtual ICollection<Topic>? Topics { get; set; }
        public int? PossibleMarks { get; set; } // = Topics.Question.Count // Topic.SubjectWeight.Sum()

    }
}