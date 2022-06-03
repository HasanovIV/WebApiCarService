using System;

namespace WebApiCarService.Models
{
    public class Car: Base.BaseModel
    {
        public string Name { get; set; }
        public string Number { get; set; }
    }
}
