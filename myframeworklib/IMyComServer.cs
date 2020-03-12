using System.Runtime.InteropServices;
namespace myframeworklib
{
    [Guid("6EE346AF-392A-4642-BAE1-66F9FE89416D")]
    [ComVisible(true)]
    public interface IMyComServer
    {
        int GetKittenCount();
    }
}