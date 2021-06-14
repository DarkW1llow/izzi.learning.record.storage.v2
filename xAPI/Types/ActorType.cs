using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;
using xAPI.Models;

namespace xAPI.Types
{
    public class ActorType : ObjectGraphType<Actor>
    {
        public ActorType()
        {
            Name = "ActorType";
            Field(x => x.UniqueId, type: typeof(GuidGraphType)).Description("");
            Field(x => x.EmailAddress, type: typeof(StringGraphType)).Description("");
            Field(x => x.Name, type: typeof(StringGraphType)).Description("");
            Field(x => x.ObjectType, type: typeof(StringGraphType)).Description("");
        }
    }
}
