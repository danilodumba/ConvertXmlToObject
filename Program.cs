using System;
using System.IO;
using System.Xml.Serialization;
using ConvertXmlToObject.Objects;

namespace ConvertXmlToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convertendo XML 1");

            var fileStream = new FileStream(@"./XML/pedido_tipo_1.xml", FileMode.Open);
            var xmlSerializer = new XmlSerializer(typeof(Pedido));
            var pedido1 = xmlSerializer.Deserialize(fileStream);

            Console.WriteLine("XML 1 convertido");

            Console.WriteLine("Convertendo XML Avacalhado");

            var fileStream2 = new FileStream(@"./XML/pedido_avacalhado.xml", FileMode.Open);
            var xmlSerializer2 = new XmlSerializer(typeof(Pedido2));
            var pedido2 = xmlSerializer2.Deserialize(fileStream2);

            Console.WriteLine("XML avacalhado convertido");
        }
    }
}
