using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Group_Project.Models
{
    public class QuestionAnswers
    {
        [DisplayName("Question ID")]
        public int Id { get; set; }
        [DisplayName("Question")]
        public string TextOfQuestion { get; set; }

        public virtual Topic Topics { get; set; }

        // public Question Question { get; set; }
        [DisplayName("Possible Answer 1")]
        public string Answer1 { get; set; }
        [DisplayName("Possible Answer 2")]
        public string Answer2 { get; set; }
        [DisplayName("Possible Answer 3")]
        public string Answer3 { get; set; }
        [DisplayName("Possible Answer 4")]
        public string Answer4 { get; set; }
        [Range(1, 4, ErrorMessage = "The Answer index has to be between 1-4")]
        [DisplayName("Correct Answer")]
        public int CorrectIndex { get; set; }
    }
}
