using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Xml;
namespace BlogUi.Models
{
    public class XmlToDatabase
    {
        [Key]
        public int id { get; set; }
        public DateTime DateCreated { get; set; }
        public string XmlGenerated { get; set; }
        public string fileName { get; set; }
        public GroupHeader GRPHID { get; set; } = new GroupHeader();
    }
}
