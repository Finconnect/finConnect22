
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogUi.Models
{
    public class Currency
    {
        [Key]
        public int ccyId{ get; set; }
        public string ccyCd{ get; set; }
        public string ccyNm{ get; set; }
        public decimal ccyExch{ get; set; }
        //public decimal ccyExch11{ get; set; }

    }
}
