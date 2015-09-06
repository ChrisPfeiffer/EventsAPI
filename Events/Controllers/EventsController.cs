using Events.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using System.Web.Script.Serialization;
using System.IO;
using System.Web.Http.Cors;
using System.Configuration;
namespace Events.Controllers
{
    public class EventsController : ApiController
    {

        //get all events
        [EnableCors(origins: "http://chrispfeiffer.github.io", headers: "*", methods: "*")]
        public IEnumerable<NYT_Event> GetEvents(string parameters, string facetSearch)
        {
            EventResponse eventResponse = new EventResponse();
                        
            string url = "http://api.nytimes.com/svc/events/v2/listings.json?&"+parameters +"&radius=2000"+ "&filters=" + facetSearch +"&api-key="+ConfigurationManager.AppSettings["apiKey"];
            
            WebRequest request = WebRequest.Create(url);
            using(WebResponse ws = request.GetResponse())
            {
                using(var reader = new StreamReader(ws.GetResponseStream()))
                {
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    var jsonText = reader.ReadToEnd();
                    eventResponse = (EventResponse)serializer.Deserialize(jsonText, typeof(EventResponse));
                }
            }

            List<NYT_Event> events = eventResponse.results;

            return events;                        
        }

    }
}
