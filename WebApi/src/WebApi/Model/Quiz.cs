using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model
{
    public class Quiz
    {
        [Key]
        public string QuizId { get; set; }
        public string QuizName { get; set; }
        public List<QuestionsAndAnswers> QuizSheet { get; set; }
    }
}
