using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Net;

namespace SimuladorSegurosResidenciais.controller
{
    class LoadZipCode
    {
        bool isValid;
        int zipCode;                
        string street;
        string neighborhood;
        string city;        
        string state;        

        public LoadZipCode(int zipCode)
        {
            setZipCode(zipCode.ToString());            
            if (zipCode > 0)
            {                
                try
                {
                    using (var client = new WebClient())
                    {
                        client.Headers.Add("content-type", "application/json");
                        string response = client.DownloadString("https://viacep.com.br/ws/" + zipCode + "/json");                        
                        dynamic data = JObject.Parse(response);
                        street = data.logradouro;
                        neighborhood = data.bairro;
                        city = data.localidade;
                        state = data.uf;
                        isValid = true;
                    }
                }
                catch (Exception e)
                {
                    isValid = false;
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void setZipCode(string zipCode)
        {
            if (zipCode.Length == 8)
            {
                try
                {
                    this.zipCode = int.Parse(zipCode);
                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }   

        public bool isSuccessed()
        {
            return isValid;// && (street != "" || neighborhood != "" || city != "" || state != "");
        }

        public string getStreet()
        {
            return street;
        }

        public string getNeighborhood()
        {
            return neighborhood;
        }

        public string getCity()
        {
            return city;
        }

        public string getState()
        {
            return state;
        }
    }
}
