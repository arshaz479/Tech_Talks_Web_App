﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tech_Talks_Web_App.Business
{
    //The schedule 
    public class Schedule
    {
        //Shedule id
        public int Id { get; set; }

        //Speaker id relationship key
        public int SpeakerId  { get; set; }

        //Sponser id relationship key
        public int SponsorId { get; set; }

        //Discussion id relationship key
        public int DiscussionId { get; set; }

        //Speaker link
        public Speaker Speaker { get; set; }

        //Sponsor link
        public Sponsor Sponsor { get; set; }

        //Discussion link
        public Discussion Discussion { get; set; }

        //Date time of the discussion
        public DateTime ScheduledTime { get; set; }

    }
}
