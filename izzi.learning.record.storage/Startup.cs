using GraphQL.Server;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using xAPI;
using xAPI.Models.LRSDbContext;
using xAPI.Mutations;
using xAPI.Queries;
using xAPI.Types;
using xAPI.Types.InputType;

namespace izzi.learning.record.storage
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<LRSDbContext>();
            services.AddSingleton<StarWarsData>();
            services.AddSingleton<StarWarsQuery>();
            services.AddScoped<GraphQLQuery>();
            services.AddSingleton<StarWarsMutation>();
            services.AddScoped<GraphQLMutation>();
            services.AddSingleton<HumanType>();
            services.AddSingleton<HumanInputType>();
            services.AddSingleton<DroidType>();
            services.AddSingleton<AttendanceType>();
            services.AddSingleton<AttendanceInputType>();
            services.AddSingleton<ActorType>();
            services.AddSingleton<ActorInputType>();
            services.AddSingleton<ObjectType>();
            services.AddSingleton<DefinitionType>();
            services.AddSingleton<NameType>();
            services.AddSingleton<DescriptionType>();
            services.AddSingleton<StatementType>();
            services.AddSingleton<StatementInputType>();
            services.AddSingleton<ObjectGraphType>();
            services.AddSingleton<FilterDetailType>();
            services.AddSingleton<CharacterInterface>();
            services.AddSingleton<EpisodeEnum>();
            services.AddScoped<ISchema, GraphQLSchema>();
            services.AddDbContext<LRSDbContext>(opt => opt.UseMySQL("server=171.244.40.91;uid=root;pwd=BringM3F00d;database=foodlink"));

            services.AddLogging(builder => builder.AddConsole());
            services.AddHttpContextAccessor();

            services.AddGraphQL(options =>
            {
                options.EnableMetrics = true;
            })
            .AddErrorInfoProvider(opt => opt.ExposeExceptionStackTrace = true)
            .AddSystemTextJson();
            //.AddUserContextBuilder(httpContext => new GraphQLUserContext { User = httpContext.User });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            var scope = app.ApplicationServices.CreateScope();
            var service = scope.ServiceProvider.GetService<GraphQLQuery>();
            // add http for Schema at default url /graphql
            app.UseGraphQL<ISchema>();

            // use graphql-playground at default url /ui/playground
            app.UseGraphQLPlayground();
        }
    }
}
