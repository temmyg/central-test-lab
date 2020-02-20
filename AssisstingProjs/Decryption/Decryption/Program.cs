using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QC.BaseLib.Security;

namespace Decryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string ent = CryptoAPI.Encrypt("password", "P@ssW03d");
            ent = "zEYqsw3XoQHGLgHd+5lqNUhv2vLK1VS38nRKqBT1PVpgQAdM9PyPPPnOm4Ri8G6yWLDn6kB9F9UOX6Gc2Vxk8lNAfFRTVHJJTjY=";
            string pswdHash = CryptoAPI.ComputeHash("12345678");
            //string pswd = CryptoAPI.Decrypt("ly7Xesz7x8eNA1DEVKeAHs0XB896Eoz941S6hNjU+Ajh33br8Y6avIcUrlA6ZqW1fKQo2k+bKyniidzVksxJv1NAfFRTVHJJTjY=", "P@ssW03d");
        }
    }
}
