using CryptoProject.Domain_Model;

namespace CryptoProject
{
    public class CryptoKey : INotifyBase
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
