using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace student_manager.API.DomainModels
{
    public class Adress
    {
        public Guid Id { get; set; }
        public String PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }
        public Guid StudentId { get; set; }
    }
}
