using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tech_Talks_Web_App.Business
{
    //Reperesents a discussion
    public class Discussion
    {
        //Discussion id 
        public int Id { get; set; }

        //Discussion topic
        public string Topic { get; set; }

        //Addional information
        public string Description {get; set;}
    }
}
