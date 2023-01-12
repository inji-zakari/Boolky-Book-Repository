using BulkyBook.Core.IUnitOfWork;
using BulkyBook.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoolkyBook.WebUI.Areas.Admin.Controllers
{
    public class CoverTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CoverTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<CoverType> coverTypes = _unitOfWork.CoverType.GetAll();
            return View(coverTypes);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CoverType coverType)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.CoverType.Add(coverType);
                _unitOfWork.Save();
                TempData["success"] = "Cover Type Created Successfully!";
                return RedirectToAction("Index");
            }
            return View(coverType);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            var coverType = _unitOfWork.CoverType.GetFirstOrDefault(x => x.Id == id);
            return View(coverType);
        }
        [HttpPost]
        public IActionResult Update(CoverType coverType)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.CoverType.Update(coverType);
                _unitOfWork.Save();
                TempData["success"] = "Cover Type Updated Successfully!";
                return RedirectToAction("Index");
            }
            return View(coverType);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var coverType = _unitOfWork.CoverType.GetFirstOrDefault(x => x.Id == id);
            return View(coverType);
        }
        [HttpPost]
        public IActionResult Delete(CoverType coverType)
        {
            if (coverType != null)
            {
                _unitOfWork.CoverType.Remove(coverType);
                _unitOfWork.Save();
                TempData["success"] = "CoverType Deleted Successfully!";
                return RedirectToAction("Index");
            }
            return View(coverType);
        }
    }
}
