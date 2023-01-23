using Group_Project.Data;
using Group_Project.Models;
using Group_Project.Repository;
using Group_Project.Repository.IRepository;
using Group_Project.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging;
using System;
using System.Drawing.Printing;

namespace Group_Project.Controllers
{
	public class QuestionController : Controller
	{
		private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _env;


		public QuestionController(IWebHostEnvironment env, MyDbContext context, IUnitOfWork unitOfWork)
		{
			_env = env;
			_unitOfWork = unitOfWork;
		}

        public IActionResult Index()
        {		
            return View();
        }

		public IActionResult Seed()
		{
            Seed seed = new Seed();
            seed.SeedDb(_unitOfWork);
			return RedirectToAction("ListOfQuestions");
        }
        
        [HttpPost]
		public ActionResult UploadImage(List<FormFile> files)
		{
			var filePath = "";
			foreach(IFormFile photo in Request.Form.Files)
			{
				string serverMapPath = Path.Combine(_env.WebRootPath , "Image", photo.FileName);
				using (var stream = new FileStream( serverMapPath, FileMode.Create))
				{
					photo.CopyTo(stream);
				}
				filePath = "https://localhost:44367/" + "Image/" + photo.FileName;
			}
			return Json(new { url = filePath});
		}

		public  async Task<IActionResult> ListOfQuestions()
		{
			return View(await _unitOfWork.QuestionAnswers.GetAllQuestionAnswersAs());
		}

		public async Task<IActionResult> Edit(int id)
		{
			return View(await _unitOfWork.QuestionAnswers.GetAs(id));
		}

		[HttpPost]
		public ActionResult EditSave(QuestionAnswers questionAnswer)
		{
			_unitOfWork.QuestionAnswers.Update(questionAnswer);
			_unitOfWork.Save();
			return RedirectToAction("ListOfQuestions");
		}

		public IActionResult Create()
		{
			return View();
		}

		public async Task<IActionResult> DeleteConfirm(int id)
		{
			return View(await _unitOfWork.QuestionAnswers.GetAs(id));
		}

		public IActionResult Delete(int id)
		{
			_unitOfWork.QuestionAnswers.Delete(_unitOfWork.QuestionAnswers.Get(id));
			_unitOfWork.Save();
			return RedirectToAction("ListOfQuestions");
        }

		public IActionResult Save(QuestionAnswers questionAnswer)
		{

			var topic = _unitOfWork.Topic.Get(1);
            questionAnswer.Topics = topic;
			_unitOfWork.QuestionAnswers.Add(questionAnswer);
			_unitOfWork.Save();
            return RedirectToAction ("Index");
		}

		public async Task<IActionResult> Details(int id)
		{
			return View(await _unitOfWork.QuestionAnswers.GetAs(id));

        }
	}
}
