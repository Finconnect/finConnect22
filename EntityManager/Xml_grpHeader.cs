using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace EntityManager
{
    public class Xml_grpHeader
    {
        [XmlRoot(ElementName = "SttlmInf")]
        public class SttlmInf
        {
            [XmlElement(ElementName = "SttlmMtd")]
            public string SttlmMtd { get; set; }
        }

        [XmlRoot(ElementName = "FinInstnId")]
        public class FinInstnId
        {
            [XmlElement(ElementName = "BICFI")]
            public string BICFI { get; set; }
        }

        [XmlRoot(ElementName = "InstgAgt")]
        public class InstgAgt
        {
            [XmlElement(ElementName = "FinInstnId")]
            public FinInstnId FinInstnId { get; set; }
        }

        [XmlRoot(ElementName = "InstdAgt")]
        public class InstdAgt
        {
            [XmlElement(ElementName = "FinInstnId")]
            public FinInstnId FinInstnId { get; set; }
        }

        [XmlRoot(ElementName = "GrpHdr")]
        public class GrpHdr
        {
            [XmlElement(ElementName = "MsgId")]
            public string MsgId { get; set; }
            [XmlElement(ElementName = "CreDtTm")]
            public string CreDtTm { get; set; }
            [XmlElement(ElementName = "NbOfTxs")]
            public string NbOfTxs { get; set; }
            [XmlElement(ElementName = "SttlmInf")]
            public SttlmInf SttlmInf { get; set; }
            [XmlElement(ElementName = "InstgAgt")]
            public InstgAgt InstgAgt { get; set; }
            [XmlElement(ElementName = "InstdAgt")]
            public InstdAgt InstdAgt { get; set; }
        }

        [XmlRoot(ElementName = "FIToFICstmrCdtTrf")]
        public class FIToFICstmrCdtTrf
        {
            [XmlElement(ElementName = "GrpHdr")]
            public GrpHdr GrpHdr { get; set; }
        }


        public List<XML_CreditTransferInstruction> _CreditTransferInstructions { get; set; }

    }
}
