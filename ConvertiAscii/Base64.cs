using System;
using System.Text;

namespace ConvertiAscii
{
    public class Base64
    {
        public static string Base64Convert()
        {
            string input = "Ciao";
            byte[] toEncodeAsBytes = ASCIIEncoding.ASCII.GetBytes(input);

            string r = Convert.ToBase64String(toEncodeAsBytes);
            return r;
        }
    }
}
