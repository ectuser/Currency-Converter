using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Network
    {
        public static string GetRequest(string url)
        {
            WebRequest request = WebRequest.Create(url); 
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse(); // OK
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            string result = "error";
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd(); 
                Console.WriteLine(responseFromServer);
                result = responseFromServer;
            }
  
            response.Close();
            return result;
        }
    }
}
