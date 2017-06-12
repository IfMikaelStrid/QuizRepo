using System.ComponentModel.DataAnnotations;

namespace WebApi.Model
{
    public class QuestionsAndAnswers
    {
        public int QuestionNumber { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}