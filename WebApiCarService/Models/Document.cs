using System;

namespace WebApiCarService.Models
{
    public class Document: Base.BaseModel
    {
        public Guid CarId { get; set; }
        public virtual Car Car { get; set; }

        public Guid WorkerId { get; set; }

        public virtual Worker Worker { get; set; }
    }
}
