using System.Runtime.InteropServices;
namespace mycorelib
{
    [Guid("D758F66B-F93B-4E2E-9491-98C21F407560")]
    [ComVisible(true)]
    public interface IMyComServer
    {
        public int GetKittenCount();
    }
}