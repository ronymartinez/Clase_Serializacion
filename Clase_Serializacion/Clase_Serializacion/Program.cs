using System;
using System.IO;
using System.Xml.Serialization;

namespace Clase_Serializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(rutaEscritorio, "personaje.xml");

            Personaje personaje = new Mago(100, "CarpinchoAsesino", 250);
            Personaje personaje = new Mago(100, "CarpinchoAsesino", 250);

            IEnumerable
            SerializarAXml(rutaEscritorio, personaje);
            //DeserializarDesdeXml<Personaje>(rutaArchivo);
            Console.WriteLine(personaje);

        }
        private static void SerializarAXml <T> (string ruta, T objeto)
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(streamWriter, objeto);
            }
        }
        private static T DeserializarDesdeXml<T>(string ruta) where T : class
        {
            using (StreamReader streamReader = new StreamReader(ruta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                //T objeto = (T) xmlSerializer.Deserialize(streamReader);
                T objeto =  xmlSerializer.Deserialize(streamReader) as T;
                return objeto;
            }
        }
    }
}
