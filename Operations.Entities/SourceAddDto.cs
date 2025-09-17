using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Operations.Entities
{
    public class SourceAddDto
    {
        /// <summary>
        /// Unique Source identifier 
        /// </summary>
        [Required]
        public Guid idSource { get; set; }

        /// <summary>
        /// Description Source
        /// </summary>
        /// 
        [Required]
        public string Source { get; set; }

        /// <summary>
        /// Name of Data Base
        /// </summary>
        /// 
        [Required]
        public string DataBaseName { get; set; }
    }
}
