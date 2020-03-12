using System.Linq;
namespace mynetstdlib
{
    public class MyFunctions
    {
        public int GetKittenCount()
        {
           
            using (var db = new MyDbContext())
            {
                db.Database.EnsureCreated();
                return db.Kittens.Count();
            }
            
        }
    }
}