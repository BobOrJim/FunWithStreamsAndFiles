using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;

namespace StreamsAndFiles.UnitTests
{
    [TestClass]
    public class XMLTests
    {
        private List<Movie> movies = new();

        public XMLTests()
        {
            movies.Add(new Movie {Name = "The Hateful Eight", Minutes = 100});
            movies.Add(new Movie {Name = "Django Unchained", Minutes = 110});
            movies.Add(new Movie {Name = "Inglourious Basterds", Minutes = 120});
            movies.Add(new Movie {Name = "Sin City", Minutes = 130});
            movies.Add(new Movie {Name = "Jackie Brown", Minutes = 140});
        }

        [TestMethod]
        public void WriteMoviesToXML_MoviesShouldBeEqualAsReadFromXML()
        {
            //Arrange
            var settings = new Settings() { FilePath = @"C:\MyOneDrive\OneDrive - Centiro Solutions AB\Skrivbordet\Studies SystemUtvecklare\FunWithStreamsAndFiles\src\StreamsAndFiles.UnitTests\test.xml" };
            var sut = new XML(settings);
            var expected = movies;

            //Act
            sut.WriteToFileAsXML(movies);
            var actual = sut.ReadFileAsXML();

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }
    }
}
