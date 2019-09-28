using System.Data.Entity;

namespace WebEval.Models
{

    public class DataContext2: DbContext
    {
        public DataContext2(): base ("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<WebEval.Models.Grade> Grades { get; set; }
    }
}