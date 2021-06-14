//using GraphQL.Types;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using xAPI.Models;

//namespace xAPI.Types.InputType
//{
//    public class ObjectInputType : InputObjectGraphType<Models.Object>
//    {
//        public ObjectInputType()
//        {
//            Field(x => x.UniqueId, type: typeof(GuidGraphType)).Description("");
//            Field(x => x.Id, type: typeof(StringGraphType)).Description("");
//            Field(x => x.ObjectType, type: typeof(StringGraphType)).Description("");
//            Field(x => x.Definition, type: typeof(DefinitionType)).Description("");
//        }
//    }

//    public class DefinitionInputType : InputObjectGraphType<Definition>
//    {
//        public DefinitionInputType()
//        {
//            Field(x => x.InteractionType, type: typeof(StringGraphType)).Description("");
//            Field(x => x.Type, type: typeof(StringGraphType)).Description("");
//            Field(x => x.Names, type: typeof(ListGraphType<NameType>)).Description("");
//            Field(x => x.Descriptions, type: typeof(ListGraphType<DescriptionType>)).Description("");
//        }
//    }

//    public class NameInputType : InputObjectGraphType<Name>
//    {
//        public NameInputType()
//        {
//            Field(x => x.Language, type: typeof(StringGraphType)).Description("");
//            Field(x => x.ActivityName, type: typeof(StringGraphType)).Description("");
//        }
//    }

//    public class DescriptionInputType : InputObjectGraphType<Description>
//    {
//        public DescriptionInputType()
//        {
//            Field(x => x.Language, type: typeof(StringGraphType)).Description("");
//            Field(x => x.DescriptionInfo, type: typeof(StringGraphType)).Description("");
//        }
//    }
//}
