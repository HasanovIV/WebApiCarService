using System;

namespace WebApiCarService.Models
{
    public class Worker: Base.BaseModel
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Telephone { get; set; }
    }
}
