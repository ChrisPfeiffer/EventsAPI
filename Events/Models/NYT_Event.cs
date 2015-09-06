using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Events.Models
{
    public class NYT_Event
    {
        public int event_id { get; set; }
        public int event_schedule_id { get; set; }
        public string last_modified { get; set; }
        public string event_name { get; set; }
        public string event_detail_url { get; set; }
        public string web_description { get; set; }
        public string venue_name { get; set; }
        public string venue_detail_url { get; set; }
        public string geocode_latitude { get; set; }
        public string geocode_longitude { get; set; }
        public string borough { get; set; }
        public string neighborhood { get; set; }
        public string street_address { get; set; }
        public string cross_street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string telephone { get; set; }
        public string venue_website { get; set; }
        public string price { get; set; }
        public string critic_name { get; set; }
        public string category { get; set; }
        public bool times_pick { get; set; }
        public bool free { get; set; }
        public bool kid_friendly { get; set; }
        public bool last_chance { get; set; }
        public bool festival { get; set; }
        public bool long_running_show { get; set; }
        public bool previews_and_openings { get; set; }
        public string date_time_description { get; set; }
        public string recurring_start_date { get; set; }
        public List<string> recur_days { get; set; }
        public string postal_code { get; set; }
        public string subcategory { get; set; }
        public string theater_overview_url { get; set; }
        public string theater_review_url { get; set; }
        public string theater_ticket_url { get; set; }
        public string recurring_end_date { get; set; }
    }

    public class EventResponse
    {
        public string status { get; set; }
        public string copyright { get; set; }
        public string num_restults { get; set; }
        
        public List<NYT_Event> results { get; set; }       

    }
}