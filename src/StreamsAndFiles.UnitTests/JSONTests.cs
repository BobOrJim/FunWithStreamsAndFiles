using Common.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Common;
using System.IO;

namespace StreamsAndFiles.UnitTests
{
    [TestClass]
    public class JSONTests
    {
        private List<Movie> movies = new();

        public JSONTests()
        {
            movies.Add(new Movie { Name = "The Hateful Eight", Minutes = 100 });
            movies.Add(new Movie { Name = "Django Unchained", Minutes = 110 });
            movies.Add(new Movie { Name = "Inglourious Basterds", Minutes = 120 });
            movies.Add(new Movie { Name = "Sin City", Minutes = 130 });
            movies.Add(new Movie { Name = "Jackie Brown", Minutes = 140 });
        }

        [TestMethod]
        public void WriteMoviesToJson_MoviesShouldBeEqualAsReadFromJson()
        {
            //Arrange
            var settings = new Settings() { FilePath = @"C:\MyOneDrive\OneDrive - Centiro Solutions AB\Skrivbordet\Studies SystemUtvecklare\FunWithStreamsAndFiles\src\StreamsAndFiles.UnitTests\test.json" };
            var sut = new JSON(settings);
            var expected = movies;

            //Act
            sut.WriteToFileAsJson(movies);
            var actual = sut.ReadFileAsJson();

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }
    }
}

