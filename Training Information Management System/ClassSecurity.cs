using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace TIMS
{
    public static class ClassSecurity
    {
        public static bool ValidateLoginDetail(string password)
        {
            string sourceData;
            byte[] sourceDataBinary;

            byte[] passwordBinary;

            sourceData = "Me@TIMS.btit.com";

            //Create a byte array from source data
            sourceDataBinary = ASCIIEncoding.ASCII.GetBytes(sourceData);
            passwordBinary = ASCIIEncoding.ASCII.GetBytes(password);

            //Compute hash based on password
            byte[] sourceDataHash, passwordHash;

            sourceDataHash = new MD5CryptoServiceProvider().ComputeHash(sourceDataBinary);
            passwordHash = new MD5CryptoServiceProvider().ComputeHash(passwordBinary);

            bool bEqual = false;
            if (sourceDataHash.Length == passwordHash.Length)
            {
                int i = 0;
                while ((i < sourceDataHash.Length) && (sourceDataHash[i] == passwordHash[i]))
                {
                    i += 1;
                }

                if (i == sourceDataHash.Length)
                {
                    bEqual = true;
                }
            }

            if (bEqual)
                return true;
            else
                return false;
        }

        public static string HashString(string given)
        {
            byte[] givenBinary = ASCIIEncoding.ASCII.GetBytes(given);

            byte[] outputHash = new MD5CryptoServiceProvider().ComputeHash(givenBinary);

            return ConvertByteArrayToString(outputHash);
        }

        public static string ConvertByteArrayToString(byte[] givenArray)
        {
            string output = "";

            for (int i = 0; i < givenArray.Length; i++)
            {
                output = output + "" + givenArray[i];
            }

            return output;
        }

        static string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length - 1; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }
    }
}
