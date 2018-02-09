﻿using System;
using System.Xml.Serialization;

namespace Statnett.EdxLib.ModelExtensions
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "edx.entsoe.eu.StatusDocument.xsd")]
    [XmlRoot(Namespace = "edx.entsoe.eu.StatusDocument.xsd")]
    public class StatusDocument
    {        
        [XmlElement(ElementName = "finalMessageStatus", Namespace = "")]
        public MessageStatus FinalMessageStatus { get; set; }

        [XmlElement(ElementName = "edxReplyMetadata", Namespace = "")]
        public EdxReplyMetadata EdxReplyMetadata { get; set; }

        [XmlArrayItem(ElementName = "messageStatus", Type = typeof(MessageStatus))]
        [XmlArray(ElementName = "statusHistory", Namespace = "")]
        public MessageStatus[] StatusHistory { get; set; }
    }
}