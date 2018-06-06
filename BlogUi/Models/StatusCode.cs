using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogUi.Models
{
    public class StatusCode
    {
        [Key]
        public int stsCodeId{ get; set; }
        public string stsCode{ get; set; }
        public string stsName{ get; set; }
        public string stsDesc{ get; set; }

    }
}
