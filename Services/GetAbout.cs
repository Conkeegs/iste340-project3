using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Project3_FinalExam.Services
{
    public class GetAbout : IGetAbout
    {
        public async Task<About> GetAllAbout()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/about", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<About>(data);

                    return rtnResults;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    About aboutList = new About();
                    return aboutList;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    About aboutList = new About();
                    return aboutList;
                    //return "Exception"; ;
                }
            }
        }

    }
}
