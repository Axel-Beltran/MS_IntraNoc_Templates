using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Izzi.Noc.Entities.DataStructure
{
    [Table("INOC.TEMPLATE")]
    public class Template
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("TEMPLATEID")]
        public int TemplateId { get; set; }
        [Column("CREATIONDATE")]
        public DateTime CreationDate { get; set; }
        [Column("DESCRIPTION")]
        public string Description { get; set; }
    }
}
