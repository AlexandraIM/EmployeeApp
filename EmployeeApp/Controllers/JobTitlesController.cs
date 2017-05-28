using System.Linq;
using System.Web.Http;
using EmployeeApp.Models;

namespace EmployeeApp.Controllers
{
    public class JobTitlesController : ApiController
    {
        private EmployeeContext db = new EmployeeContext();

        /// <summary>
        /// Use to fill dropdown list
        /// </summary>
        /// <returns>
        /// Returns List of all job titles
        /// </returns>
        // GET: api/JobTitles
        public IQueryable<JobTitle> GetJobTitles()
        {
            return db.JobTitles;
        }

    }
}