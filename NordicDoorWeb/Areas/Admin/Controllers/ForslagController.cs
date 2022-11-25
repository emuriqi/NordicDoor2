using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NordicDoor.DataAccess.Repository;
using NordicDoor.DataAccess.Repository.IRepository;
using NordicDoor.Models;
using NordicDoor.Models.ViewModels;
using NordicDoorWeb.Models;

namespace NordicDoorWeb.Controllers
{
    public class ForslagController : Controller
    {
        private readonly IUniteOfWork _uniteOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ForslagController(IUniteOfWork uniteOfWork, IWebHostEnvironment hostEnvironment)
        {
            _uniteOfWork = uniteOfWork;
            _hostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
           
            return View();
        }


        public IActionResult Upsert(int? id)
        {
            ForslagVM forslagvm = new()
            {
                forslags = new(),
                AnsattList = _uniteOfWork.Ansatt.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Etternavn,
                    Value = i.Team.ToString()
                }),
            };
           
            if (id == null || id == 0)
            {
                //ViewBag.AnsattList = AnsattList;
                return View(forslagvm);
            }
           else 
            {
                
            }

            return View(forslagvm);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(ForslagVM obj, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(wwwRootPath, @"images\forslags");
                    var extension = Path.GetExtension(file.FileName);

                    using (var fileStreams = new FileStream(Path.Combine(uploads,fileName+extension), FileMode.Create))
                    {
                        file.CopyTo(fileStreams);
                    }
                    obj.forslags.ImageUrl = @"\images\forslags\" + fileName + extension;
                }
                _uniteOfWork.Forslag.Add(obj.forslags);
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

        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            var ansattList = _uniteOfWork.Forslag.GetAll();
            return Json(new { data = ansattList });
        }
        #endregion


    }




}


