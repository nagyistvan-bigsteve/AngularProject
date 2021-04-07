using System;
using System.Runtime.Serialization;

namespace AngularProject.Models
{
    public class Duckbill
    {
        [IgnoreDataMemberAttribute]
        public Guid ID { get; set; }

        public string Name { get; set; }
    }
}
