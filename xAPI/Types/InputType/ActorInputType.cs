using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;
using xAPI.Models;

namespace xAPI.Types.InputType
{
    public class ActorInputType : InputObjectGraphType<Actor>
    {
        public ActorInputType()
        {
            Name = "InputActor";
            Field(x => x.UniqueId, type: typeof(IdGraphType), nullable: true).Description("");
            Field(x => x.EmailAddress, type: typeof(StringGraphType), nullable: true).Description("");
            Field(x => x.Name, type: typeof(StringGraphType), nullable: true).Description("");
            Field(x => x.ObjectType, type: typeof(StringGraphType), nullable: true).Description("");
        }
    }
}
