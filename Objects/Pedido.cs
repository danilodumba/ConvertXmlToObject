using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ConvertXmlToObject.Objects
{
    [XmlRoot(ElementName = "pedido")]
    public class Pedido
    {
        [XmlElement(ElementName = "numero")]
        public int Numero { get; set; }

        [XmlElement(ElementName = "data")]
        public DateTime Data { get; set; }

        [XmlElement(ElementName = "cliente")]
        public string Cliente { get; set; }

        [XmlArray("itens")]
        public List<PedidoItens> Itens { get; set; }
    }

    [XmlType("item")]
    public class PedidoItens
    {
        [XmlElement(ElementName = "id")]
        public int ProdutoID { get; set; }

        [XmlElement(ElementName = "produto")]
        public string Produto { get; set; }

        [XmlElement(ElementName = "quantidade")]
        public int Quantidade { get; set; }
    }
}