using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonaWebApp.Models
{
    public class Projects
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int ProjectModel { get; set; }
        public int ProjectMakeUp { get; set; }
        public int ProjectPhotographer { get; set; }
        public int ProjectPhoto { get; set; }
    }
}