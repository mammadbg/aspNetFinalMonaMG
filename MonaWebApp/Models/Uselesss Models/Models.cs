using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonaWebApp.Models
{
    public class Models
    {
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public int ModelTypeId { get; set; }
        public string ModelPosition { get; set; }
        public string ModelImage { get; set; }
        public string ModelHoverImage { get; set; }
        public string ModelSuccessStory { get; set; }
        public string ModelFbAccount { get; set; }
        public string ModelInstagramAccount { get; set; }
        public string ModelTwitterAccount { get; set; }
        public string ModelYoutubeAccount { get; set; }
    }
}