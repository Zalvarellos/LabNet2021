using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Practica.EF.Entities;

namespace Practica.EF.Logic
{
    public class CountryLogic
    {
        public List<Country> GetPaises()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://restcountries.eu/rest/v2/all");

            request.Method = "GET";

            request.Accept = "application/json";

            request.ContentType = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using(Stream dataStream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(dataStream))
                        {
                            string data = reader.ReadToEnd();

                            List<Country> countries = JsonConvert.DeserializeObject<List<Country>>(data);

                            return countries;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
