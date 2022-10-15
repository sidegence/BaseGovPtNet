using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseGovPtNet.Entities
{
    public class ContractSummary
    {
        public string? contractingProcedureType { get; set; }
        public string? publicationDate { get; set; }
        public string? contracted { get; set; }
        public string? contracting { get; set; }
        public string? initialContractualPrice { get; set; }
        public string? objectBriefDescription { get; set; }
        public string? signingDate { get; set; }
        public int id { get; set; }
    }
}
