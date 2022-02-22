using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ConvertXmlToObject.Objects
{
    [XmlRoot(ElementName = "pedido")]
    public class Pedido2
    {
        [XmlElement(ElementName = "numero")]
        public int Numero { get; set; }

        [XmlElement(ElementName = "data")]
        public DateTime Data { get; set; }

        [XmlElement(ElementName = "cliente")]
        public string Cliente { get; set; }

        [XmlElement("item")]
        public List<PedidoItens> Itens { get; set; }
    }

}