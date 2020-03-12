using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using mynetstdlib;
namespace myframeworklib
{
    [Guid("EC8550DA-AA7A-42F5-9718-D28A12668449")]
    [ProgId("SOKittensFramework")]
    [ClassInterface(ClassInterfaceType.None)]


    [ComVisible(true)]
    public class FrameworkKittens : IMyComServer
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
