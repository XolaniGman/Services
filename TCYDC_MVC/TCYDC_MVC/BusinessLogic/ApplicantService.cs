using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCYDC_MVC.Data;
using TCYDC_MVC.Models;

namespace TCYDC_MVC.BusinessLogic
{
    public class ApplicantService : IApplicantService
    {
        private readonly ApplicationDbContext _db;

        public ApplicantService(ApplicationDbContext db)
        {
            this._db = db;
        }
        public void SubmitApplication(Applicant applicant)
        {
            using(_db)
            {
                var application = new ApplicantDt
                {
                    Fullnames = applicant.Fullnames,
                    Address = applicant.Address,
                    Age = applicant.Age,
                    ContactNumber = applicant.ContactNumber,
                    EmailAddress = applicant.EmailAddress,
                    Gender = applicant.Gender,
                    hasQualification = applicant.hasQualification,
                    DateAccepted = new DateTime(),
                    DateCreated = DateTime.Now,
                    DateOfBirth = applicant.DateOfBirth,
                    HighestGrade = applicant.HighestGrade,
                    ID_Document = applicant.ID_Document,
                    CV = applicant.CV,
                    OtherQualification = applicant.OtherQualification,
                    Qualification = applicant.Qualification
                };
                _db.Applicants.Add(application);
                _db.SaveChanges();
            }
        }
        public List<Applicant> ViewAllApplications()
        {
            return _db.Applicants.Select( x => new Applicant
            {
                Fullnames = x.Fullnames,
                EmailAddress = x.EmailAddress,
                Age = x.Age,
                Gender = x.Gender,
                DateOfBirth = x.DateOfBirth,
                Address = x.Address,
                ContactNumber = x.ContactNumber,
                DateAccepted = x.DateAccepted,
                DateCreated = x.DateCreated,
                hasQualification = x.hasQualification,
                HighestGrade = x.HighestGrade,
                CV = x.CV,
                ID_Document = x.ID_Document,
                OtherQualification = x.OtherQualification,
                Qualification = x.Qualification
            }).ToList();
        }
    }
}
