//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonaWebApp.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Blog
    {
        public int BlogId { get; set; }
        public string BlogName { get; set; }
        public Nullable<System.DateTime> BlogRegisterDate { get; set; }
        public Nullable<int> BlogAuthor { get; set; }
        public string BlogQuote { get; set; }
        public Nullable<int> BlogQuoteAuthor { get; set; }
        public Nullable<int> BlogCategory { get; set; }
        public Nullable<int> BlogTags { get; set; }
        public Nullable<int> BlogPhoto { get; set; }
    
        public virtual BlogCategory BlogCategory1 { get; set; }
        public virtual Human Human { get; set; }
        public virtual BlogTag BlogTag { get; set; }
        public virtual Photo Photo { get; set; }
        public virtual Human Human1 { get; set; }
    }
}