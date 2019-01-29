using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonaWebApp.Models
{
    public class Humans
    {
        public int HumanId { get; set; }
        public string HumanName { get; set; }
        public int HumanPosition { get; set; }
        public string Email { get; set; }
        public string  HumanResume { get; set; }
        public int HumanSocialNetworkId { get; set; }
        public string HumanStory { get; set; }
        public DateTime HumanRegisterDate  { get; set; }
        public int HumanPhoto { get; set; }
    }
}