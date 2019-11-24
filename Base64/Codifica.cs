using System;
using System.Text;

namespace Base64
{
    public class Codifica
    {
        
        public string EncodeStringToBase64(string stringToEncode)
        {
            Console.Write("Inserisci testo: ");
            string p = Console.ReadLine();


            return Convert.ToBase64String(Encoding.UTF8.GetBytes(stringToEncode));
        }
    }
}
