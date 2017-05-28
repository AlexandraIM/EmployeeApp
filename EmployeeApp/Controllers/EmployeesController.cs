using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using EmployeeApp.Models;

namespace EmployeeApp.Controllers
{
    public class EmployeesController : ApiController
    {
        private EmployeeContext db = new EmployeeContext();
        /// <summary>
        /// Returns list of Employees
        /// </summary>
        
        // GET: api/Employees
        public IQueryable<Employee> GetEmployees()
        {
            return db.Employees;
        }

        /// <summary>
        /// Add Employee to DataBase
        /// </summary>
        /// <param name="employee"></param>
        
        // POST: api/Employees
        [ResponseType(typeof(Employee))]
        public async Task<IHttpActionResult> PostEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Employees.Add(employee);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = employee.Id }, employee);
        }



        /// <summary>
        /// Delete Employee from DataBase by Employee Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // DELETE: api/Employees/5
        [ResponseType(typeof(Employee))]
        [HttpDelete]
        public async Task<IHttpActionResult> DeleteEmployee(int id)
        {
            Employee employee = await db.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            db.Employees.Remove(employee);
            await db.SaveChangesAsync();

            return Ok(employee);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmployeeExists(int id)
        {
            return db.Employees.Count(e => e.Id == id) > 0;
        }
    }
}