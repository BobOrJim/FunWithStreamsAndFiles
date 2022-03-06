using Common;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StreamsAndFiles
{
    public class JSON
    {
        private string filePath;

        public JSON(Settings settings)
        {
            filePath = settings.FilePath;
        }

        public void WriteToFileAsJson(List<Movie> movies)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            File.WriteAllText(filePath, JsonSerializer.Serialize(movies));
        }

        public List<Movie> ReadFileAsJson()
        {
            string text = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Movie>>(text);
        }

    }
}
