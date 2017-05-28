using System.Collections.Generic;
using System.Data.Entity;

namespace EmployeeApp.Models
{
    public class DBIitializer: DropCreateDatabaseAlways<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            IList<JobTitle> jobTitles = new List<JobTitle>
            {
                new JobTitle() { Id = 1, Title = "CEO"},
                new JobTitle() { Id = 1, Title = "Business Analyst"},
                new JobTitle() { Id = 1, Title = "Developer"},
                new JobTitle() { Id = 1, Title = "QA"}
            };

            foreach (var job in jobTitles)
            {
                context.JobTitles.Add(job);
            }
            base.Seed(context);
        }
    }
}