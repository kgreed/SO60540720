using System.Linq;
namespace mynetstdlib
{
    public class MyFunctions
    {
        public int GetKittenCount()
        {
           
            using (var db = new MyDbContext())
            {
                return db.Kittens.Count();
            }
            
        }
    }
}