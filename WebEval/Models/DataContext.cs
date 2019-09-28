using System.Data.Entity;

namespace WebEval.Models
{
    public class DataContext: DbContext
    {
        public DataContext(): base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<WebEval.Models.Student> Students { get; set; }
    }
}