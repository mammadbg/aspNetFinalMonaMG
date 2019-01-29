using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonaWebApp.Models
{
    public class SocialNetworks
    {
        public int SocialNetworkId { get; set; }
        public string SocialName { get; set; }
        public int Facebook { get; set; }
        public int Twitter  { get; set; }
        public int Youtube { get; set; }
        public int Pinterest { get; set; }
    }
}