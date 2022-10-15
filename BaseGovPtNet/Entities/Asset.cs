using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseGovPtNet.Entities
{
    public class Asset
    {
        public string? designation { get; set; }
        public string? basePrice { get; set; }
        public string? cpvs { get; set; }
        public string? lots { get; set; }
        public List<Entity>? contractingEntities { get; set; }
        public object? transmissionType { get; set; }
        public string? alienationDate { get; set; }
        public string? alienationLocal { get; set; }
        public string? alienationRules { get; set; }
        public string? aditionalInformation { get; set; }
        public string? description { get; set; }
        public string? status { get; set; }
        public int id { get; set; }
    }
}
