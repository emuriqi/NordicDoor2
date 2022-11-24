using Microsoft.AspNetCore.Mvc;
using NordicDoor.DataAccess.Repository.IRepository;
using NordicDoorWeb.Models;

namespace NordicDoorWeb.Controllers
{
    public class AnsattController : Controller
    {
        private readonly IUniteOfWork _uniteOfWork;

        public AnsattController(IUniteOfWork uniteOfWork)
        {
            _uniteOfWork = uniteOfWork;

        }
        public IActionResult Index()
        {
            IEnumerable<AnsattModel> objAnsatteliste = _uniteOfWork.Ansatt.GetAll();
            return View(objAnsatteliste);
        }

        public IActionResult Opprett()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Opprett(AnsattModel obj)
        {
            if (ModelState.IsValid)
            {
                _uniteOfWork.Ansatt.Add(obj);
                _uniteOfWork.Save();
                TempData["success"] = "Ansatt ble registrert";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Rediger(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //var forslagFromDb = _db.NyttForslag.Find(id);
            var ansatteFromDbFirst = _uniteOfWork.Ansatt.GetFirstOrDefault(u => u.Id == id);

            if (ansatteFromDbFirst == null)
            {
                return NotFound();
            }

            return View(ansatteFromDbFirst);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Rediger(AnsattModel obj)
        {
            if (ModelState.IsValid)
            {
                _uniteOfWork.Ansatt.Update(obj);
                _uniteOfWork.Save();
                TempData["success"] = "Ansatte ble redigert";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Slett(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //var forslagFromDb = _db.NyttForslag.Find(id);
            var ansattModelFromDbFirst = _uniteOfWork.Ansatt.GetFirstOrDefault(u => u.Id == id);


            if (ansattModelFromDbFirst == null)
            {
                return NotFound();
            }

            return View(ansattModelFromDbFirst);

        }

        [HttpPost, ActionName("Slett")]
        [ValidateAntiForgeryToken]
        public IActionResult SlettPOST(int? id)
        {
            var obj = _uniteOfWork.Ansatt.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _uniteOfWork.Ansatt.Remove(obj);
            _uniteOfWork.Save();
            TempData["success"] = "Ansatt ble slettet";
            return RedirectToAction("Index");
        }

    }

}
    

