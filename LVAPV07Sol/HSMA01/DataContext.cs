using HSMA01.Entidades;
using System.Data.Entity;

namespace HSMA01
{
    public class DataContext:DbContext
    {
       public DbSet<Student> Students { get; set; }
        public DataContext():base("name=miConexion")
        {
        }
    }
}
