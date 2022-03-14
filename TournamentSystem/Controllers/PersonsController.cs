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

		// GET: PersonsController/Details/5
		public ActionResult Details(int id) {
			IPersonManager personManager = new PersonManager();
			return View(personManager.GetPersonById(id));
		}

		// GET: PersonsController/Create
		public ActionResult Create() {
			return View();
		}

		// POST: PersonsController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection) {
			try {
				IPersonManager personManager = new PersonManager();
				personManager.CreatePerson(collection);
				return RedirectToAction(nameof(Index));
			} catch {
				return View();
			}
		}

		// GET: PersonsController/Edit/5
		public ActionResult Edit(int id) {
			return View();
		}

		// POST: PersonsController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection) {
			try {
				IPersonManager personManager = new PersonManager();
				personManager.UpdatePerson(id, collection);
				return RedirectToAction(nameof(Index));
			} catch {
				return View();
			}
		}

		// GET: PersonsController/Delete/5
		public ActionResult Delete(int id) {
			IPersonManager personManager = new PersonManager();
			personManager.DeletePerson(id);
			return View();
		}

		// POST: PersonsController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection) {
			try {
				return RedirectToAction(nameof(Index));
			} catch {
				return View();
			}
		}
	}
}
