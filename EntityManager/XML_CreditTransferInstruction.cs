using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace EntityManager
{

    [XmlRoot]
    public class XML_CreditTransferInstruction
    {
        [XmlRoot(ElementName = "PmtId")]
        public class PmtId
        {
            [XmlElement(ElementName = "InstrId")]
            public string InstrId { get; set; }
            [XmlElement(ElementName = "EndToEndId")]
            public string EndToEndId { get; set; }
            [XmlElement(ElementName = "TxId")]
            public string TxId { get; set; }
        }

        [XmlRoot(ElementName = "IntrBkSttlmAmt")]
        public class IntrBkSttlmAmt
        {
            [XmlAttribute(AttributeName = "Ccy")]
            public string Ccy { get; set; }
            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "InstdAmt")]
        public class InstdAmt
        {
            [XmlAttribute(AttributeName = "Ccy")]
            public string Ccy { get; set; }
            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "PstlAdr")]
        public class PstlAdr
        {
            [XmlElement(ElementName = "StrtNm")]
            public string StrtNm { get; set; }
            [XmlElement(ElementName = "BldgNb")]
            public string BldgNb { get; set; }
            [XmlElement(ElementName = "PstCd")]
            public string PstCd { get; set; }
            [XmlElement(ElementName = "TwnNm")]
            public string TwnNm { get; set; }
            [XmlElement(ElementName = "Ctry")]
            public string Ctry { get; set; }
        }

        [XmlRoot(ElementName = "UltmtDbtr")]
        public class UltmtDbtr
        {
            [XmlElement(ElementName = "Nm")]
            public string Nm { get; set; }
            [XmlElement(ElementName = "PstlAdr")]
            public PstlAdr PstlAdr { get; set; }
        }

        [XmlRoot(ElementName = "Dbtr")]
        public class Dbtr
        {
            [XmlElement(ElementName = "Nm")]
            public string Nm { get; set; }
            [XmlElement(ElementName = "PstlAdr")]
            public PstlAdr PstlAdr { get; set; }
        }

        [XmlRoot(ElementName = "Othr")]
        public class Othr
        {
            [XmlElement(ElementName = "Id")]
            public string Id { get; set; }
        }

        [XmlRoot(ElementName = "Id")]
        public class Id
        {
            [XmlElement(ElementName = "Othr")]
            public Othr Othr { get; set; }
            [XmlElement(ElementName = "IBAN")]
            public string IBAN { get; set; }
        }

        [XmlRoot(ElementName = "DbtrAcct")]
        public class DbtrAcct
        {
            [XmlElement(ElementName = "Id")]
            public Id Id { get; set; }
        }

        [XmlRoot(ElementName = "FinInstnId")]
        public class FinInstnId
        {
            [XmlElement(ElementName = "BICFI")]
            public string BICFI { get; set; }
        }

        [XmlRoot(ElementName = "DbtrAgt")]
        public class DbtrAgt
        {
            [XmlElement(ElementName = "FinInstnId")]
            public FinInstnId FinInstnId { get; set; }
        }

        [XmlRoot(ElementName = "CdtrAgt")]
        public class CdtrAgt
        {
            [XmlElement(ElementName = "FinInstnId")]
            public FinInstnId FinInstnId { get; set; }
        }

        [XmlRoot(ElementName = "Cdtr")]
        public class Cdtr
        {
            [XmlElement(ElementName = "Nm")]
            public string Nm { get; set; }
            [XmlElement(ElementName = "PstlAdr")]
            public PstlAdr PstlAdr { get; set; }
        }

        [XmlRoot(ElementName = "CdtrAcct")]
        public class CdtrAcct
        {
            [XmlElement(ElementName = "Id")]
            public Id Id { get; set; }
        }

        [XmlRoot(ElementName = "Purp")]
        public class Purp
        {
            [XmlElement(ElementName = "Cd")]
            public string Cd { get; set; }
        }

        [XmlRoot(ElementName = "CdOrPrtry")]
        public class CdOrPrtry
        {
            [XmlElement(ElementName = "Cd")]
            public string Cd { get; set; }
        }

        [XmlRoot(ElementName = "Tp")]
        public class Tp
        {
            [XmlElement(ElementName = "CdOrPrtry")]
            public CdOrPrtry CdOrPrtry { get; set; }
        }

        [XmlRoot(ElementName = "RfrdDocInf")]
        public class RfrdDocInf
        {
            [XmlElement(ElementName = "Tp")]
            public Tp Tp { get; set; }
            [XmlElement(ElementName = "Nb")]
            public string Nb { get; set; }
            [XmlElement(ElementName = "RltdDt")]
            public string RltdDt { get; set; }
        }

        [XmlRoot(ElementName = "Strd")]
        public class Strd
        {
            [XmlElement(ElementName = "RfrdDocInf")]
            public RfrdDocInf RfrdDocInf { get; set; }
        }

        [XmlRoot(ElementName = "RmtInf")]
        public class RmtInf
        {
            [XmlElement(ElementName = "Strd")]
            public Strd Strd { get; set; }
        }

        [XmlRoot(ElementName = "CdtTrfTxInf")]
        public class CdtTrfTxInf
        {
            [XmlElement(ElementName = "PmtId")]
            public PmtId PmtId { get; set; }
            [XmlElement(ElementName = "IntrBkSttlmAmt")]
            public IntrBkSttlmAmt IntrBkSttlmAmt { get; set; }
            [XmlElement(ElementName = "IntrBkSttlmDt")]
            public string IntrBkSttlmDt { get; set; }
            [XmlElement(ElementName = "InstdAmt")]
            public InstdAmt InstdAmt { get; set; }
            [XmlElement(ElementName = "ChrgBr")]
            public string ChrgBr { get; set; }
            [XmlElement(ElementName = "UltmtDbtr")]
            public UltmtDbtr UltmtDbtr { get; set; }
            [XmlElement(ElementName = "Dbtr")]
            public Dbtr Dbtr { get; set; }
            [XmlElement(ElementName = "DbtrAcct")]
            public DbtrAcct DbtrAcct { get; set; }
            [XmlElement(ElementName = "DbtrAgt")]
            public DbtrAgt DbtrAgt { get; set; }
            [XmlElement(ElementName = "CdtrAgt")]
            public CdtrAgt CdtrAgt { get; set; }
            [XmlElement(ElementName = "Cdtr")]
            public Cdtr Cdtr { get; set; }
            [XmlElement(ElementName = "CdtrAcct")]
            public CdtrAcct CdtrAcct { get; set; }
            [XmlElement(ElementName = "Purp")]
            public Purp Purp { get; set; }
            [XmlElement(ElementName = "RmtInf")]
            public RmtInf RmtInf { get; set; }
        }
    }

}
