using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCYDC_MVC.BusinessLogic;
using TCYDC_MVC.Models;

namespace TCYDC_MVC.Controllers
{
    public class ApplicantController : Controller
    {
        private readonly IApplicantService _db;

        public ApplicantController(IApplicantService db)
        {
            this._db = db;
        }
        public IActionResult Index()
        {
            return View(_db.ViewAllApplications());
        }


        public ViewResult Add_Applicant() => View();

        [HttpPost]
        public IActionResult Add_Applicant(Applicant Model)
        {
            if(ModelState.IsValid)
            {
                _db.SubmitApplication(Model);
            }
            return View(nameof(Index));
        }

    }
}
