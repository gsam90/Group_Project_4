using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Group_Project.Models
{
    public class Topic
    {
        [DisplayName("Topic Id")]
        public int Id { get; set; }
        
        public Certificate Certificate { get; set; }
        [DisplayName("Topic Title")]
        public string Title { get; set; }
        [DisplayName("Topic Description")]
        public string Description { get; set; }
        [DisplayName("Topic Subject Weight")]
        public virtual ICollection<QuestionAnswers>? QuestionAnswers { get; set; }

    }
}
