namespace BaseGovPtNet.Entities
{
    public class Document
    {
        public string? description { get; set; }
        public int id { get; set; }
    }

    public class Contract
    {
        public string? contractFundamentationType { get; set; }
        public object? closeDate { get; set; }
        public object? causesDeadlineChange { get; set; }
        public bool? ambientCriteria { get; set; }
        public List<Document>? documents { get; set; }
        public object? observations { get; set; }
        public List<Entity>? invitees { get; set; }
        public string? publicationDate { get; set; }
        public object? contractingProcedureUrl { get; set; }
        public object? endOfContractType { get; set; }
        public object? totalEffectivePrice { get; set; }
        public string? directAwardFundamentationType { get; set; }
        public int announcementId { get; set; }
        public List<Entity>? contestants { get; set; }
        public bool? increments { get; set; }
        public object? causesPriceChange { get; set; }
        public string? frameworkAgreementProcedureId { get; set; }
        public string? frameworkAgreementProcedureDescription { get; set; }
        public string? contractingProcedureType { get; set; }
        public bool? contractTypeCS { get; set; }
        public string? executionPlace { get; set; }
        public bool? centralizedProcedure { get; set; }
        public string? cpvs { get; set; }
        public string? nonWrittenContractJustificationTypes { get; set; }
        public string? initialContractualPrice { get; set; }
        public object? contractStatus { get; set; }
        public string? executionDeadline { get; set; }
        public string? contractTypes { get; set; }
        public string? objectBriefDescription { get; set; }
        public bool? income { get; set; }
        public string? signingDate { get; set; }
        public string? cpvsValue { get; set; }
        public List<Entity>? contracted { get; set; }
        public List<Entity>? contracting { get; set; }
        public bool? cocontratantes { get; set; }
        public bool? aquisitionStateMemberUE { get; set; }
        public object? infoAquisitionStateMemberUE { get; set; }
        public object? groupMembers { get; set; }
        public string? cpvsType { get; set; }
        public string? cpvsDesignation { get; set; }
        public string? description { get; set; }
        public int id { get; set; }
    }
}
