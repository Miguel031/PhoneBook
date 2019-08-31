
using System.Data.Entity;

namespace apiPhone.Models
{
    public class DataContext: DbContext
    {
        public DataContext():base("Default Conection")
        {

        }

    }
}