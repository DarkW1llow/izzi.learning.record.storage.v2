using GraphQL;
using GraphQL.Types;
using System;
using xAPI.Models;
using xAPI.Models.LRSDbContext;
using xAPI.Types;
using xAPI.Types.InputType;

namespace xAPI.Mutations
{
    public class GraphQLMutation : ObjectGraphType
    {
        public GraphQLMutation(LRSDbContext dbContext)
        {
            CreateAttendance(dbContext);
            CreateActor(dbContext);
            //CreateObject(dbContext);
            CreateStatement(dbContext);
        }

        public void CreateAttendance(LRSDbContext dbContext)
        {
            Name = "AttendanceMutation";

            Field<AttendanceType>(
                "createAttendance",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<AttendanceInputType>> { Name = "param" }
                ),
                resolve: context =>
                {
                    var param = context.GetArgument<Attendance>("param");
                    var temp = new Attendance()
                    {
                        Id = param.Id,
                        Deleted = false,
                        MerchantId = param.MerchantId,
                        ReferenceId = param.ReferenceId,
                        RelationId = param.RelationId,
                        TargetId = param.TargetId,
                        CreatedBy = param.CreatedBy,
                        Version = 1,
                        Note = string.Empty,
                        TimeStamp = param.TimeStamp,
                        CreatedDate = DateTime.Now
                    };
                    dbContext.Add(temp);
                    dbContext.SaveChanges();
                    return temp;
                });
        }

        public void CreateActor(LRSDbContext dbContext)
        {
            Name = "ActorMutation";

            Field<ActorType>(
                "createActor",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ActorInputType>> { Name = "param" }
                ),
                resolve: context =>
                {
                    var param = context.GetArgument<Actor>("param");
                    var temp = new Actor()
                    {
                        UniqueId = Guid.NewGuid(),
                        EmailAddress = param.EmailAddress,
                        Name = param.Name,
                        ObjectType = param.ObjectType
                    };
                    dbContext.Add(temp);
                    dbContext.SaveChanges();
                    return temp;
                });
        }

        //public void CreateObject(LRSDbContext dbContext)
        //{
        //    Name = "ObjectMutation";

        //    Field<ObjectType>(
        //        "createObject",
        //        arguments: new QueryArguments(
        //            new QueryArgument<NonNullGraphType<ObjectInputType>> { Name = "param" }
        //            ),
        //        resolve: context =>
        //        {
        //            var param = context.GetArgument<Models.Object>("param");
        //            var temp = new Models.Object
        //            {
        //                UniqueId = Guid.NewGuid(),
        //                Id = param.Id,
        //                Definition = param.Definition,
        //                ObjectType = param.ObjectType
        //            };
        //            dbContext.Add(temp);
        //            dbContext.SaveChanges();
        //            return temp;
        //        });
        //}

        public void CreateStatement(LRSDbContext dbContext)
        {
            Name = "StatementMutation";

            Field<StatementType>(
                "createStatement",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StatementInputType>> { Name = "param" }
                    ),
                resolve: context =>
                {
                    var param = context.GetArgument<Statement>("param");
                    var temp = new Statement
                    {
                        Id = Guid.NewGuid(),
                        TimeStamp = param.TimeStamp,
                        Actor = param.Actor,
                        Object = param.Object,
                        Verb = param.Verb,
                        Version = 1
                    };
                    dbContext.Add(temp);
                    dbContext.SaveChanges();
                    return temp;
                });
        }
    }
}
