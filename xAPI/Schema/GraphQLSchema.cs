using GraphQL.Types;
using GraphQL.Utilities;
using System;
using xAPI.Mutations;
using xAPI.Queries;

namespace xAPI
{
    public class GraphQLSchema : Schema
    {
        public GraphQLSchema(IServiceProvider provider)
            : base(provider)
        {
            //Query = provider.GetRequiredService<StarWarsQuery>();
            Query = provider.GetRequiredService<GraphQLQuery>();
            //Mutation = provider.GetRequiredService<StarWarsMutation>();
            Mutation = provider.GetRequiredService<GraphQLMutation>();
        }
    }
}
