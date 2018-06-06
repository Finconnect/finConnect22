using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogUi.Models
{

    public class CountryCode
    {
        [Key]
        public int ctryId{ get; set; }
        public string ctryCode{ get; set; }
        public string ctryNm{ get; set; }

    }
}
