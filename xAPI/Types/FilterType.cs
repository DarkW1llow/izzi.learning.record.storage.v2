using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace xAPI.Types
{
    public class FilterType
    {
    }

    public class FilterDetailType : InputObjectGraphType<Filter>
    {
        public FilterDetailType()
        {
            Name = "FilterDetail";
            Field(x => x.Id, type: typeof(StringGraphType));
            Field(x => x.Type, type: typeof(IntGraphType), nullable: true);
            Field(x => x.TokenUser, type: typeof(StringGraphType));
            Field(x => x.LanguageId, type: typeof(StringGraphType), nullable: true);
            Field(x => x.MerchantId, type: typeof(StringGraphType), nullable: true);
            Field(x => x.TargetId, type: typeof(StringGraphType), nullable: true);

            Field(x => x.EmailAddress, type: typeof(StringGraphType));
            Field(x => x.StartDate, type: typeof(DateTimeGraphType));
            Field(x => x.EndDate, type: typeof(DateTimeGraphType));
            Field(x => x.Summary, type: typeof(StringGraphType), nullable: true);
            Field(x => x.Description, type: typeof(StringGraphType), nullable: true);
            Field(x => x.Location, type: typeof(StringGraphType), nullable: true);
            Field(x => x.Method, type: typeof(StringGraphType), nullable: true);
            Field(x => x.Minutes, type: typeof(IntGraphType), nullable: true);
            Field(x => x.AuthorizeCode, type: typeof(StringGraphType));

        }
    }

    public class Filter
    {
        public Guid MerchantId { get; set; }
        public Guid LanguageId { get; set; }
        public Guid Id { get; set; }
        public string Keyword { get; set; }
        public int? Type { get; set; }
        public int? SubType { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }

        public DateTime? FromUtc { get; set; }
        public DateTime? ToUtc { get; set; }

        public List<Guid> CategoryIds { get; set; }
        public List<Guid> AuthorIds { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? ThemeWebId { get; set; }
        public string TokenUser { get; set; }
        public bool? Published { get; set; }
        public bool? Active { get; set; }

        public string EmailAddress { get; set; } //Required
        public DateTime StartDate { get; set; } //Required
        public DateTime EndDate { get; set; } //Required
        public string Location { get; set; } //Optional
        public string Summary { get; set; } //Optional
        public string Method { get; set; } //Optional
        public int? Minutes { get; set; } //Optional
        public string Description { get; set; } //Optional
        public string AuthorizeCode { get; set; }

        public Guid FormId { get; set; }
        public int? AllStatus { get; set; }
        public int? Status { get; set; }
        public Guid? TargetId { get; set; }

        public int? Capacity { get; set; }

        public int? FromTotal { get; set; }
        public int? ToTotal { get; set; }
    }
}
