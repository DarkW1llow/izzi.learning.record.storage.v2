using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace xAPI.Models
{
    public class Statement
    {
        public DateTime TimeStamp { get; set; }
        public int Version { get; set; }
        [Key]
        public Guid Id { get; set; }
        public string Actor { get; set; }
        public string Verb { get; set; }
        public string Object { get; set; }
    }
}
