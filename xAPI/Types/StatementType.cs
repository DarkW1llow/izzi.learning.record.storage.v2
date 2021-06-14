using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;
using xAPI.Models;

namespace xAPI.Types
{
    public class StatementType : ObjectGraphType<Statement>
    {
        public StatementType()
        {
            Field(x => x.Id, type: typeof(GuidGraphType)).Description("");
            Field(x => x.Version, type: typeof(IntGraphType)).Description("");
            Field(x => x.TimeStamp, type: typeof(DateTimeGraphType)).Description("");
            Field(x => x.Actor, type: typeof(StringGraphType)).Description("");
            Field(x => x.Verb, type: typeof(StringGraphType)).Description("");
            Field(x => x.Object, type: typeof(StringGraphType)).Description("");
        }
    }
}
