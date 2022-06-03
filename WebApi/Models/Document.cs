using System;

namespace WebApi.Models
{
    public class Document: Base.BaseModel
    {
        public Guid CarId { get; set; }
        public virtual Car Car { get; set; }

        public Guid WorkerId { get; set; }
    }
}
