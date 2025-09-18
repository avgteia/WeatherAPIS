namespace Weather.Commons.Entities
{
    public class NonQueryResultEntity
    {
        /// <summary>
        /// Records Affected 
        /// </summary>
        public int RecordsAffected { get; set; }

        /// <summary>
        /// Error message text
        /// </summary>
        public string? NonAffectionReason { get; set; }
    }
}
