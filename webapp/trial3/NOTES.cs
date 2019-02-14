using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace trial3
{
    public partial class NOTES
    {
        //public Users(string )
        [Key]
        public string ID { get; set; }
        [Required]
        public string content { get; set; }
        [Required]
        public string title {get; set;}
        
        public System.DateTime created_on {get; set;}
        public System.DateTime last_updated_on {get; set;}
    
        public string EMAIL{get; set;}
    }
}