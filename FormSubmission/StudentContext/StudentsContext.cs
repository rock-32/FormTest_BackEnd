using FormSubmission.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FormSubmission.StudentContext
{
    public class StudentsContext:DbContext
    {

        public StudentsContext(DbContextOptions<StudentsContext> options) : base(options)
        {

        }
        public DbSet<Students> students {  get; set; }

        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }


    }
}
