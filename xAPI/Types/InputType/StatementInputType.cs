using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;
using xAPI.Models;

namespace xAPI.Types.InputType
{
    public class StatementInputType : InputObjectGraphType<Statement>
    {
        public StatementInputType()
        {
            Name = "InputStatement";
            Field(x => x.Id, type: typeof(GuidGraphType)).Description("");
            Field(x => x.Version, type: typeof(IntGraphType)).Description("");
            Field(x => x.TimeStamp, type: typeof(DateTimeGraphType)).Description("");
            Field(x => x.Actor, type: typeof(StringGraphType)).Description("");
            Field(x => x.Verb, type: typeof(StringGraphType)).Description("");
            Field(x => x.Object, type: typeof(StringGraphType)).Description("");
        }
    }
}
