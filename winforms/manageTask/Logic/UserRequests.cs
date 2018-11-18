﻿using manageTask.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manageTask.Logic
{
   public class UserRequests
    {

        public static List<User> getSimpleWorkers()
        {
            HttpClient client1 = new HttpClient();
            client1.BaseAddress = new Uri($@"{GlobalProp.URI}");
            client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response1 = client1.GetAsync($"api/Users/getWorkers").Result;
            if (response1.IsSuccessStatusCode)
            {
                var CardsJson = response1.Content.ReadAsStringAsync().Result;
                List<User> workers = JsonConvert.DeserializeObject<List<User>>(response1.Content.ReadAsStringAsync().Result);
                if (workers != null)
                    return workers;
                return null;

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response1.StatusCode, response1.ReasonPhrase);
                return null;
            }

        }


        public static bool addWorkerToProject(int projectId,List<User>users)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create($@"{GlobalProp.URI}api/addWorkersToProject/{projectId}");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string cardsString = Newtonsoft.Json.JsonConvert.SerializeObject(users, Formatting.None);
                    streamWriter.Write(cardsString);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                if (httpResponse.StatusDescription == "OK")
                    return true;
                else return false;

            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public static bool sendMessage(int userId, Object message)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create($@"{GlobalProp.URI}api/sendMessageToManagers/{userId}");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string cardsString = Newtonsoft.Json.JsonConvert.SerializeObject(message, Formatting.None);
                    streamWriter.Write(cardsString);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                if (httpResponse.StatusDescription == "OK")
                    return true;
                else return false;

            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        public static List<User> getWorkerNotInProject(int idProject)
        {
            HttpClient client1 = new HttpClient();
            client1.BaseAddress = new Uri($@"{GlobalProp.URI}");
            client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response1 = client1.GetAsync($"api/getWorkerNotProject/{idProject}").Result;
            if (response1.IsSuccessStatusCode)
            {
                var CardsJson = response1.Content.ReadAsStringAsync().Result;
                List<User> workers = JsonConvert.DeserializeObject<List<User>>(response1.Content.ReadAsStringAsync().Result);
                if (workers != null)
                    return workers;
                return null;

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response1.StatusCode, response1.ReasonPhrase);
                return null;
            }

        }


    }
}
