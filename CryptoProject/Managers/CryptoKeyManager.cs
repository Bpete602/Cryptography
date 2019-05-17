using CryptoProject.Domain_Model;
using CryptoProject.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography;

namespace CryptoProject.Managers
{
    public sealed class CryptoKeyManager : INotifyBase
    {
        #region Public Methods

        public void CreateKey()
        {
            AesManaged aes = new AesManaged() { KeySize = 128 };
            aes.GenerateKey();
            CryptoKeys.Add(new CryptoKey() { Name = "Test", Value = RandomShit.ByteArrayToString(aes.Key) });
        }

        #endregion

        #region Public Properties

        public ObservableCollection<CryptoKey> CryptoKeys { get; set; } = new ObservableCollection<CryptoKey>();

        #endregion

        #region Singleton

        private static readonly Lazy<CryptoKeyManager> _instance = new Lazy<CryptoKeyManager>(() => new CryptoKeyManager());

        public static CryptoKeyManager Instance => _instance.Value;

        private CryptoKeyManager()
        {
            // Instance Initialization Code.
        }

        #endregion
    }
}
