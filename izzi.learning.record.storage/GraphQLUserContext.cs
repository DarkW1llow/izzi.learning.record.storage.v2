using System.Collections.Generic;
using System.Security.Claims;

namespace izzi.learning.record.storage
{
    public class GraphQLUserContext : Dictionary<string, object>
    {
        public ClaimsPrincipal User { get; set; }
    }
}
