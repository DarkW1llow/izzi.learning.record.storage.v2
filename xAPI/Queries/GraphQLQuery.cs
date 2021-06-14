using GraphQL;
using GraphQL.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using xAPI.Models;
using xAPI.Models.LRSDbContext;
using xAPI.Types;

namespace xAPI.Queries
{
    public class GraphQLQuery : ObjectGraphType
    {
        public GraphQLQuery(LRSDbContext dbContext)
        {
            AttendanceQueries(dbContext);
            ActorQuery(dbContext);
            StatementQuery(dbContext);
            ActorInfoQuery(dbContext);
        }

        public void AttendanceQueries(LRSDbContext dbContext)
        {
            Name = "AttendanceQuery";
            Field<AttendanceType>(
               "attendance",
               arguments: new QueryArguments(
                       new QueryArgument<NonNullGraphType<FilterDetailType>> { Name = "param" }
               ),
               resolve: context =>
               {
                   var message = string.Empty;
                   var stopWatch = new Stopwatch();
                   message += " Step01: ";
                   stopWatch.Start();
                   var param = context.GetArgument<Filter>("param");
                   return dbContext.Attendances.SingleOrDefault(e => e.Id.Equals(param.Id) && e.MerchantId.Equals(param.MerchantId) && !e.Deleted);

               });
        }

        public void ActorQuery(LRSDbContext dbContext)
        {
            Name = "ActorQuery";
            Field<ActorType>(
               "actor",
               arguments: new QueryArguments(
                       new QueryArgument<NonNullGraphType<FilterDetailType>> { Name = "param" }
               ),
               resolve: context =>
               {
                   var param = context.GetArgument<Filter>("param");
                   return dbContext.Actors.Where(e => e.EmailAddress.Equals(param.EmailAddress)).SingleOrDefault();
               });
        }

        public void StatementQuery(LRSDbContext dbContext)
        {
            Name = "StatementQuery";
            Field<StatementType>(
               "statement",
               arguments: new QueryArguments(
                       new QueryArgument<NonNullGraphType<FilterDetailType>> { Name = "param" }
               ),
               resolve: context =>
               {
                   var param = context.GetArgument<Filter>("param");
                   return dbContext.Statements.Where(e => e.Id.Equals(param.Id)).SingleOrDefault();
               });
        }

        public void ActorInfoQuery(LRSDbContext dbContext)
        {
            Name = "ActorInfoQuery";
            Field<ActorType>(
                "actorInfo",
                arguments: new QueryArguments(
                   new QueryArgument<NonNullGraphType<FilterDetailType>> { Name = "param" }
                   ),
                resolve: context =>
                {
                    var param = context.GetArgument<Filter>("param");
                    var data = dbContext.Statements.Where(e => e.Id.Equals(param.Id)).SingleOrDefault();

                    var actorJson = data.Actor;

                    var actor = JsonConvert.DeserializeObject<Actor>(actorJson);

                    return actor;
                });
        }
    }
}
