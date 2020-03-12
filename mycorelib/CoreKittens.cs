
using System.Runtime.InteropServices;
using mynetstdlib;
namespace mycorelib
{
    [Guid("36464508-6640-4D9E-BEC9-5BF9026F1144")]
    [ProgId("SOKittensCore")]
    [ClassInterface(ClassInterfaceType.None)]   


    [ComVisible(true)]
    public class FrameworkKittens :IMyComServer
    {
        [DispId(1)]
        [ComVisible(true)]
        public int GetKittenCount()
        {
            var f = new MyFunctions();
            return f.GetKittenCount();
        }
    }

   
}
