using System;
using System.Collections.Generic;
using System.Text;

namespace xAPI.Models
{
    public class Attendance
    {
        public Guid Id { get; set; }
        public Guid TargetId { get; set; }
        public Guid RelationId { get; set; }
        public Guid MerchantId { get; set; }
        public Guid ReferenceId { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool Deleted { get; set; }
        public int Version { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
    }
}
