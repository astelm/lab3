using System;

namespace Family.Model
{
    [Serializable()]
    public class Family
    {
        [System.Xml.Serialization.XmlElement("ID")]
        public int ID { get; set; }
        [System.Xml.Serialization.XmlElement("Surname")]
        public string Surname { get; set; }
        [System.Xml.Serialization.XmlElement("Name")]
        public string Name { get; set; }
        [System.Xml.Serialization.XmlElement("Fathername")]
        public string Fathername { get; set; }
        [System.Xml.Serialization.XmlElement("Faculty")]
        public string Faculty { get; set; }
        [System.Xml.Serialization.XmlElement("FatherSpeciality")]
        public string FatherSpeciality { get; set; }
        [System.Xml.Serialization.XmlElement("MotherSpeciality")]
        public string MotherSpeciality { get; set; }
        [System.Xml.Serialization.XmlElement("BrotherNumber")]
        public uint BrotherNumber { get; set; }
        [System.Xml.Serialization.XmlElement("SisterNumber")]
        public uint SisterNumber { get; set; }
    }
}