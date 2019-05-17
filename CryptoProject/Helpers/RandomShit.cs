using System;

namespace CryptoProject.Helpers
{
    public static class RandomShit
    {
        public static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }
    }
}
