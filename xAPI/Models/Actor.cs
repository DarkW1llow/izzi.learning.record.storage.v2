using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace xAPI.Models
{
    public class Actor
    {
        [Key]
        public Guid? UniqueId { get; set; }
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public string ObjectType { get; set; }
    }
}
