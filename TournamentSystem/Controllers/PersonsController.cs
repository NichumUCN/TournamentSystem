using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TournamentSystem.Managers;
using TournamentSystem.Models;

namespace TournamentSystem.Controllers {

	public class PersonsController : Controller {
		// GET: PersonsController
		public ActionResult Index() {
			IPersonManager personManager = new PersonManager();
			return View(personManager.GetAllPersons());
		}

		//GET: PersonsController/Details/5
		public ActionResult Details(string personEmail)
		{
			IPersonManager personManager = new PersonManager();
			return View(personManager.GetPersonByEmail(personEmail));
		}

		//GET: PersonsController/Create
		public ActionResult Create() {
			return View();
		}

		//POST: PersonsController/Create
	   [HttpPost]
	   [ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection) {
			try {
				IPersonManager personManager = new PersonManager();
				personManager.CreatePersonFromForm(collection);
				return RedirectToAction(nameof(Index));
			} catch {
				return View();
			}
		}

		//GET: PersonsController/Edit/5
		public ActionResult Edit(string personEmail) {
			return View();
		}

		//POST: PersonsController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(string personEmail, IFormCollection collection) {
			try {
				IPersonManager personManager = new PersonManager();
				personManager.UpdatePerson(personEmail, collection);
				return RedirectToAction(nameof(Index));
			} catch {
				return View();
			}
		}

		//GET: PersonsController/Delete/5
		public ActionResult Delete(string personEmail) {
			IPersonManager personManager = new PersonManager();
			personManager.DeletePerson(personEmail);
			return View();
		}

		//POST: PersonsController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(string personEmail, IFormCollection collection) {
			try {
				return RedirectToAction(nameof(Index));
			} catch {
				return View();
			}
		}
	}
}
