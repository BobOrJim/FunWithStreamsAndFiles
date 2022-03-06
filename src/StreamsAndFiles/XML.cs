using Common;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace StreamsAndFiles
{
    public class XML
    {
        private string filePath;

        public XML(Settings settings)
        {
            filePath = settings.FilePath;
        }

        public void WriteToFileAsXML(List<Movie> movies)
        {
            if (File.Exists(filePath))
                File.Delete(filePath);
            
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Movie>));
            StreamWriter streamWriter = new StreamWriter(filePath);
            xmlSerializer.Serialize(streamWriter, movies);
            streamWriter.Close();
        }

        public List<Movie> ReadFileAsXML()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Movie>));
            FileStream fileStream = new FileStream(filePath, FileMode.Open);
            var myObject = (List<Movie>) xmlSerializer.Deserialize(fileStream) ?? new List<Movie>();
            return myObject;
        }
    }
}
