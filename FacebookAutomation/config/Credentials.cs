using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FacebookAutomation.config
{
    public class Credentials
    {
        public string email = "";
        public string password = "";
        public string json = "";

        public Credentials()
        {
            using (StreamReader r = new StreamReader("F:\\VS\\FacebookAutomation\\FacebookAutomation\\credentials.json"))
            {
                json = r.ReadToEnd();
            }

            dynamic array = JsonConvert.DeserializeObject(json);
            Console.WriteLine("Array::::" + array["email"]);
            email = array["email"];
            password = array["password"];
        }
    }
}
