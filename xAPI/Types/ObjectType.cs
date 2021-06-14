using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;
using xAPI.Models;

namespace xAPI.Types
{
    public class ObjectType : ObjectGraphType<Models.Object>
    {
        public ObjectType()
        {
            Field(x => x.UniqueId, type: typeof(GuidGraphType)).Description("");
            Field(x => x.Id, type: typeof(StringGraphType)).Description("");
            Field(x => x.ObjectType, type: typeof(StringGraphType)).Description("");
            Field(x => x.Definition, type: typeof(DefinitionType)).Description("");
        }
    }

    public class DefinitionType : ObjectGraphType<Definition>
    {
        public DefinitionType()
        {
            Field(x => x.InteractionType, type: typeof(StringGraphType)).Description("");
            Field(x => x.Type, type: typeof(StringGraphType)).Description("");
            Field(x => x.Names, type: typeof(ListGraphType<NameType>)).Description("");
            Field(x => x.Descriptions, type: typeof(ListGraphType<DescriptionType>)).Description("");
        }
    }

    public class NameType : ObjectGraphType<Name>
    {
        public NameType()
        {
            Field(x => x.Language, type: typeof(StringGraphType)).Description("");
            Field(x => x.ActivityName, type: typeof(StringGraphType)).Description("");
        }
    }

    public class DescriptionType : ObjectGraphType<Description>
    {
        public DescriptionType()
        {
            Field(x => x.Language, type: typeof(StringGraphType)).Description("");
            Field(x => x.DescriptionInfo, type: typeof(StringGraphType)).Description("");
        }
    }
}
