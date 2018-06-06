using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogUi.Models
{
    public class CreditTransferStatus
    {
        [Key]
        public int txStsId { get; set; }
        public string stsId { get; set; }
        public string orgEndToEndId { get; set; }
        public string orgTxId { get; set; }
        public string stsRsnPrtry { get; set; }
        public string clrSysRef { get; set; }
        public decimal orgTxRefIntrBKSttlmAmt { get; set; }
        public DateTime orgTxRefIntrBkSttlDt { get; set; }
        public string orgTxRefDbtrAgtBIC { get; set; }
        public string orgTxRefCdtrAgtBIC { get; set; }

    }

}
