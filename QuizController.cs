using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuizApp.Data;
using QuizApp.Models.ViewModels;

namespace QuizApp.Controllers
{
    public class QuizController : Controller
    {
        private readonly ApplicationDbContext dbcontext;

            public QuizController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        [HttpGet]
        public IActionResult Index()
        {
           var questions = dbcontext.Questions.Include(x => x.Options)
                .Select(x => new QuestionItem()
                {
                    Id = x.Id,
                    Text = x.Text,
                        Options = x.Options.Select
                                 (y => new SelectListItem(y.Text, y.Id.ToString())).ToList()
                })
                
                .ToList();


            return View( new QuizViewModel() { Questions = questions});
        }

        [HttpPost]
        public IActionResult Submit(List<Guid> userAnswers)
        {
            var questions = dbcontext.Questions.ToList();
            var score = 0;
            var totalScore = questions.Count;

            for( var i = 0; i< userAnswers.Count;i++)
            {
                if (questions[i].CorrectOption == userAnswers[i])
                {
                    score++;
                }
            }

            ViewBag.Score = score;
            ViewBag.TotalScore = totalScore;

            return View("Results");
        }

    }
}
