using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NordicDoor.DataAccess.Repository.IRepository;
using NordicDoor.Models;
using NordicDoorWeb.Models;

namespace NordicDoorWeb.Controllers
{
    public class ForslagController : Controller
    {
        private readonly IUniteOfWork _uniteOfWork;

        public ForslagController(IUniteOfWork uniteOfWork)
        {
            _uniteOfWork = uniteOfWork;

        }
        public IActionResult Index()
        {
            IEnumerable<AnsattModel> objAnsatteliste = _uniteOfWork.Ansatt.GetAll();
            return View(objAnsatteliste);
        }

       
        public IActionResult Upsert(int? id)
        {
            ForslagModel forslagsModel = new();

            if (id == null || id == 0)
            {
                return View(forslagsModel);
            }
           else 
            {
                
            }

            return View(forslagsModel);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(ForslagModel obj, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                //_uniteOfWork.Forslag.Update(obj);
                _uniteOfWork.Save();
                TempData["success"] = "Forslag ble redigert";
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
    

