
using BroadageSportsBackend.Service.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;
using BroadageSportsBackend.Core.Entity2;
using BroadageSportsBackend.Data;
using Microsoft.EntityFrameworkCore;

namespace BroadageSportsBackendRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class SoccerRestAPI : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;
        private readonly BroadageSportsDbContext broadageSportsDbContext;
        private const string URL = "https://s0-sports-data-api.broadage.com/soccer/match/list?date=04/06/2022";
        private string urlParameters = "";
        private const string URL2 = "https://s0-sports-data-api.broadage.com/soccer/tournament/list";

        public SoccerRestAPI(IUnitOfWork unitOfWork, IConfiguration configuration, BroadageSportsDbContext broadageSportsDbContext)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
            this.broadageSportsDbContext = broadageSportsDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<Soccer>> GetSoccer()
        {



            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(URL);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _configuration["OcpApimSubscriptionKey"]);
                    client.DefaultRequestHeaders.Add("languageId", _configuration["languageId"]);
                    client.DefaultRequestHeaders.Add("Accept", _configuration["application/json"]);
                    HttpResponseMessage response = client.GetAsync(URL).Result;


                    if (response.IsSuccessStatusCode)
                    {
                        var ccc = response.Content.ReadAsStringAsync().Result;
                        List<Soccer> oMycustomclassname = JsonConvert.DeserializeObject<List<Soccer>>(ccc);

                        foreach (var item in oMycustomclassname)
                        {
                           var AddedList= broadageSportsDbContext.Soccer.Add(item);
                           
                            broadageSportsDbContext.SaveChanges();

                        }
                        

                        return Ok(oMycustomclassname);


                    }
                    else
                    {
                        var ResponseResult = await response.Content.ReadAsStringAsync();
                        return Ok(ResponseResult);
                    }
                }






            }
            catch (WebException ex)
            {

                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"));
                    string errorText = reader.ReadToEnd();
                }
                throw;
            }
        }

        [HttpGet("tournamentlist")]
        public async Task<IActionResult> GetTournament()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(URL2);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _configuration["OcpApimSubscriptionKey"]);
                    client.DefaultRequestHeaders.Add("languageId", _configuration["languageId"]);
                    client.DefaultRequestHeaders.Add("Accept", _configuration["application/json"]);
                    HttpResponseMessage response = client.GetAsync(URL2).Result;


                    if (response.IsSuccessStatusCode)
                    {
                        var ccc = response.Content.ReadAsStringAsync().Result;
                        List<TournamentList> oMycustomclassname = JsonConvert.DeserializeObject<List<TournamentList>>(ccc);

                        foreach (var item in oMycustomclassname)
                        {
                             broadageSportsDbContext.TournamentList.Add(item);
                             
                            
                            broadageSportsDbContext.SaveChanges();
                            

                        }
                        
                        return Ok(oMycustomclassname);
                        


                    }
                    else
                    {
                        var ResponseResult = await response.Content.ReadAsStringAsync();
                        return Ok(ResponseResult);
                    }
                }






            }
            catch (WebException ex)
            {

                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"));
                    string errorText = reader.ReadToEnd();
                }
                throw;
            }
        }

        

        

    }
}
