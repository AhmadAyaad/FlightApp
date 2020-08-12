using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FlightApp.Helper
{
    class HelperMethods
    {

        public static List<T> ReadFile<T>(string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                List<T> t = JsonConvert.DeserializeObject<List<T>>(json);

                if (t!= null)
                    return t;
                return new List<T>();
            }
        }
    }
}
