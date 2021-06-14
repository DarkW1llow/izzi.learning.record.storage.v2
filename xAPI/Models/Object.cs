using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace xAPI.Models
{
    public class Object
    {
        [Key]
        public Guid UniqueId { get; set; }
        public string Id { get; set; }
        public Definition Definition { get; set; }
        public string ObjectType { get; set; }
    }

    public class Definition
    {
        public List<Name> Names { get; set; }
        public List<Description> Descriptions { get; set; }
        [Key]
        public string Type { get; set; }
        public string InteractionType { get; set; }
    }

    public class Name
    {
        [Key]
        public string Language { get; set; }
        public string ActivityName { get; set; }
    }

    public class Description
    {
        [Key]
        public string Language { get; set; }
        public string DescriptionInfo { get; set; }
    }
}
