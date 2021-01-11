using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCYDC_MVC.Models;

namespace TCYDC_MVC
{
    public interface IApplicantService
    {
        public void SubmitApplication(Applicant applicant);
        public List<Applicant> ViewAllApplications();
    }
}
