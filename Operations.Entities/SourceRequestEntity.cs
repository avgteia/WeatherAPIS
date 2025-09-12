using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Operations.Entities
{
    public class SourceRequestEntity
    {
        /// <summary>
        /// Unique Source identifier 
        /// </summary>
        [Required]
        public Guid? idSource { get; set; }

    }
}
