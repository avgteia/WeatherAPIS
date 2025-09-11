namespace Weather.Operations.Entities
{
    public class SourcesEntity
    {
        /// <summary>
        /// Unique Source identifier 
        /// </summary>
        public Guid idSource { get; set; }

        /// <summary>
        /// Description Source
        /// </summary>
        public string? Source {  get; set; }

        /// <summary>
        /// Name of Data Base
        /// </summary>
        public string? DataBaseName { get; set; }

    }
}
