using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using RiotAPITest.Models;

namespace RiotAPITest.Controllers
{
    public class RiotController : Controller
    {
        //
        // GET: /Riot/
        string DevKey = "b4e17ddf-1177-4932-8acb-89ad976f7f3a";
        string myID = "21225746";
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestData()
        {
            string sURL = "https://prod.api.pvp.net/api/lol/na/v1.2/stats/by-summoner/" + myID + "/summary?api_key=" + DevKey;

            WebRequest request = WebRequest.Create(sURL);
            WebResponse response = request.GetResponse();

            Stream stream = response.GetResponseStream();

            StreamReader reader = new StreamReader(stream);
            string content = reader.ReadToEnd();

            reader.Close();
            response.Close();
            //List<ReturnAggregatedStats> returnList = new List<ReturnAggregatedStats>();
            var settings = new JsonSerializerSettings();
            settings.MissingMemberHandling = MissingMemberHandling.Error;
            PlayerStatsSummaryListDto cont = JsonConvert.DeserializeObject<PlayerStatsSummaryListDto>(content, settings);
            foreach (var ret in cont.playerStatSummaries)
            {
                ret.aggregatedStats.losses = ret.losses;
                ret.aggregatedStats.wins = ret.wins;
                ret.aggregatedStats.playerStatSummaryType = ret.playerStatSummaryType;
            }
            return Json(JsonConvert.SerializeObject(cont), JsonRequestBehavior.AllowGet);
        }

    }
}
