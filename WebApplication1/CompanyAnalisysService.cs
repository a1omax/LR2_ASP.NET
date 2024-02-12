
using System.Collections;

namespace WebApplication1
{
    public class CompanyAnalysisService
    {
        private readonly IConfiguration _configuration;

        public CompanyAnalysisService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetCompanyWithMoreEmployees()
        {
            int microsoftEmployees = _configuration.GetValue<int>("Microsoft:Employees");
            int appleEmployees = _configuration.GetValue<int>("Apple:Employees");
            int googleEmployees = _configuration.GetValue<int>("Google:Employees");
            

            if (microsoftEmployees>= appleEmployees && microsoftEmployees >= googleEmployees) {
                return "Microsoft";
            }
            if (appleEmployees >= googleEmployees)
            {
                return "Apple";
            }
            return "Google";
        }
    }
}