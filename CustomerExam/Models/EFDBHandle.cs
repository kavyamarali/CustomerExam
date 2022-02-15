using Microsoft.EntityFrameworkCore;

namespace CustomerExam.Models
{
    public class EFDBHandle:DbContext
    {
        public string conn = "Server=KAVYAGMARALI\\SQLEXPRESS;Database=Exam_Customer;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsB)
        {
            optionsB.UseSqlServer(conn);
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
