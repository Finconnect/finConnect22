using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogUi.Models
{
    public class OrgMsgStatus
    {
        public string orgMsgId{ get; set; }
        public string orgMsgNmId{ get; set; }
        public decimal orgNbOfTx{ get; set; }
        public string stsRsnInfPrtry{ get; set; }
        public string stsRsnAddtlInf{ get; set; }
        public decimal dtldNbOfTxs{ get; set; }
        public string dtldSts{ get; set; }
        public decimal dtldCtrlSum{ get; set; }
        [Key]
        public int orgMsgStatusId{ get; set; }

    }
}
