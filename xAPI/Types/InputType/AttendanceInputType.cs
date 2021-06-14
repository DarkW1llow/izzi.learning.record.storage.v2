using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;
using xAPI.Models;

namespace xAPI.Types.InputType
{
    public class AttendanceInputType : InputObjectGraphType<Attendance>
    {
        public AttendanceInputType()
        {
            Name = "InputAttendance";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property from the owner object.");
            Field(x => x.Note, type: typeof(StringGraphType)).Description("Name property from the owner object.");
            Field(x => x.TargetId, type: typeof(GuidGraphType)).Description("SubDescription property from the owner object.");
            Field(x => x.ReferenceId, type: typeof(GuidGraphType)).Description("SubDescription property from the owner object.");
            Field(x => x.RelationId, type: typeof(GuidGraphType)).Description("SubDescription property from the owner object.");

            Field(x => x.MerchantId, type: typeof(GuidGraphType)).Description("MerchantId property from the owner object.");
            Field(x => x.CreatedBy, type: typeof(GuidGraphType), nullable: true).Description("CreatedBy property from the owner object.");
            Field(x => x.CreatedDate, type: typeof(DateTimeGraphType), nullable: true).Description("CreatedDate property from the owner object.");
            Field(x => x.TimeStamp, type: typeof(DateTimeGraphType)).Description("CreatedDate property from the owner object.");
            Field(x => x.ModifiedBy, type: typeof(GuidGraphType), nullable: true).Description("");
            Field(x => x.ModifiedDate, type: typeof(DateTimeGraphType), nullable: true).Description("");
        }
    }
}
