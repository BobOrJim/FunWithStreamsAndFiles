using Common;
using Common.Model;

namespace StreamsAndFiles
{
    public class CSV
    {
        private List<Movie> movies = new();
        private string filePathSettings;
        private string filePath;

        public CSV(Settings settings)
        {
            filePathSettings = settings.FilePath;
        }

        public void InitList()
        {
            movies.Add(new Movie{Name = "The Hateful Eight", Minutes = 100});
            movies.Add(new Movie { Name = "Django Unchained", Minutes = 110 });
            movies.Add(new Movie { Name = "Inglourious Basterds", Minutes = 120 });
            movies.Add(new Movie { Name = "Sin City", Minutes = 130 });
            movies.Add(new Movie { Name = "Jackie Brown", Minutes = 140 });
        }

        public void WriteToCsvFile()
        {
            filePath = filePathSettings + DateTime.Now.ToString("ddMMyyyyHHmmssfff") + ".csv";

            //var serializer = new CsvSerializer<IEnumerable<CsvEdiModel>>(';', true);
            //var fileContent = new StringBuilder();

            //using (var writer = new StringWriter(fileContent))
            //{
            //    serializer.Serialize(shipments.Select(EdiMapper.Map), writer);
            //}
            //File.WriteAllText(filePath, fileContent.ToString());

            //UpdateShipmentStatus(shipments.Select(s => s.idSHP).ToArray(), LegacySettings);

            //var mappedEdis = shipments.Select(s => ConvergenceEdiDto.Generated(s.Reference, ObjectType.Shipment));

        }


    }
}