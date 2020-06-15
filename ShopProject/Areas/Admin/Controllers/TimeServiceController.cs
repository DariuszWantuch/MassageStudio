using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopProject.DataAccess.Data.Repository.IRepository;
using ShopProject.Models;

namespace ShopProject.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class TimeServiceController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public TimeServiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            TimeService timeService = new TimeService();
            if (id == null)
            {

                return View(timeService);
            }

            timeService = _unitOfWork.TimeService.Get(id.GetValueOrDefault());
            if (timeService == null)
            {
                return NotFound();
            }
            return View(timeService);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(TimeService timeService)
        {

            if (ModelState.IsValid && _unitOfWork.TimeService.IsTimeServiceExist(timeService.Time) != true)
            {
                if (timeService.Id == 0)
                {
                    _unitOfWork.TimeService.Add(timeService);
                }
                else
                {
                    _unitOfWork.TimeService.Update(timeService);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(timeService);

        }


        #region API Calls

        public IActionResult GetAll()
        {

            return Json(new { data = _unitOfWork.TimeService.GetAll() });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.TimeService.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting." });
            }
            _unitOfWork.TimeService.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete success." });

        }
        #endregion
    }
}
