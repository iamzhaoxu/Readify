using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFServiceWebRole1
{
    [Serializable]
    [DataContract]
    public class ContactDetails
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [DataMember]
        public string EmailAddress
        {
            get;
            set;
        }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [DataMember]
        public string FamilyName
        {
            get;
            set;
        }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [DataMember]
        public string GivenName
        {
            get;
            set;
        }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [DataMember]
        public string PhoneNumber
        {
            get;
            set;
        }
    }
}