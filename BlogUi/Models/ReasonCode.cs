using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogUi.Models
{
    public class ReasonCode
    {
        [Key]
        public int rsnId{ get; set; }
        public string rsnNm{ get; set; }
        public string rsnDesc{ get; set; }

    }
}
