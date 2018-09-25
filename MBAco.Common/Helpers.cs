using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace Shahmat.Common
{
    public class Helpers
    {
        public static List<long> New10DigitsRandomUniqueKey(int ammount)
        {
            return New10DigitsRandomUniqueKey(null, ammount);
        }

        public static List<long> New10DigitsRandomUniqueKey(List<long> baseList, int ammount)
        {
            List<long> keys;
            if (baseList==null)
                keys = new List<long>();
            else
                keys = baseList;

            Random ran = new Random(DateTime.Now.Millisecond);

            long keyFirstPart = 0;
            long keySecondPart = 0;
            long result = 0;
            for (int i = 0; i < ammount; i++)
            {
                do
                {
                    // first 10 numbers
                    keyFirstPart = ran.Next(10000000, 99999999);
                    // last 'n' numbers, in this case 2, easy to make it bigger up to 7
                    keySecondPart = ran.Next(10, 99);

                    //total key of 10 digits
                    result = long.Parse(keyFirstPart.ToString() + keySecondPart.ToString());
                }
                while (keys.Contains(result));
                keys.Add(result);
            }
            return keys;
        }

        public static bool SendEmailViaGmail(string toAddress, string subject, string content)
        {
            return false;
        }

        public static String ToUnicodeString(string string2Encode)
        {
            Encoding srcEncoding = Encoding.GetEncoding("Windows-1250");
            UnicodeEncoding dstEncoding = new UnicodeEncoding();
            byte[] srcBytes = srcEncoding.GetBytes(string2Encode);
            byte[] dstBytes = dstEncoding.GetBytes(string2Encode);
            return dstEncoding.GetString(dstBytes);
        }

        public static string ConvertStringToUTF8(string originalString)
        {
            //Encoding encoding = Encoding.Default;
            Encoding encoding = Encoding.GetEncoding("Windows-1250");
            byte[] encBytes = encoding.GetBytes(originalString);
            byte[] utf8Bytes = Encoding.Convert(encoding, Encoding.UTF8, encBytes);
            return Encoding.UTF8.GetString(utf8Bytes);
        }

    }
}
