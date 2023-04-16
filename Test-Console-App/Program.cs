using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using CryptSharp.Utility;
using Net_Core_JS_Encryption_Decryption;
using Net_Core_JS_Encryption_Decryption.Helpers;
using Newtonsoft.Json;


namespace DotNet_Js_Encryption_Decryption
{
    /*
     * .NET Core to / from JavaScript Encryption / Decryption
     * (c) by Smart In Media 2019 / Dr. Martin Weihrauch
     * Under MIT License
     *
     *
     *
     */
    class Program
    {
        static void Main(string[] args)
        {
            var enc4 = File.ReadAllText("D:\\TatumPath\\TRX.dat");

            var dec4 = EncryptionHelper.DecryptAes(enc4, "13");

            var ench = File.ReadAllText("D:\\TatumPath\\BSC.dat");

            var dech = EncryptionHelper.DecryptAes(enc4, "13");

            var enc = EncryptionHelper.EncryptAes(dec4, "14");
            var dec5 = EncryptionHelper.DecryptAes(enc, "14");

        }

    }
}
