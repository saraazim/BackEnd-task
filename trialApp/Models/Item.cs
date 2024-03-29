﻿using System.Collections.Generic;

namespace trialApp.Models
{
    public class Owner
    {
        public int reputation { get; set; }
        public int user_id { get; set; }
        public string user_type { get; set; }
        public string profile_image { get; set; }
        public string display_name { get; set; }
        public string link { get; set; }
        public int? accept_rate { get; set; }
    }

    public class Item
    {
       
            public List<string> tags { get; set; }
            public Owner owner { get; set; }
            public bool is_answered { get; set; }
            public int view_count { get; set; }
            public int answer_count { get; set; }
            public int score { get; set; }
            public int last_activity_date { get; set; }
            public int creation_date { get; set; }
            public int question_id { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int? last_edit_date { get; set; }
        

    }
    public class RootObject
    {
        public List<Item> items { get; set; }
        public bool has_more { get; set; }
        public int quota_max { get; set; }
        public int quota_remaining { get; set; }
    }
    public class Root
    {
        public List<Item> items { get; set; }
        public List<RootObject> RootObject { get; set; }
        public List<Owner> Owner { get; set; }
       
    }
}