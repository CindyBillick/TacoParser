using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything
            TacoParser sut = new TacoParser();//arrange
            var actual = sut.Parse("34.073638, -84.677017, Taco Bell Acwort...");//act
            Assert.NotNull(actual);

        }

        [Theory]

        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638, -84.677017, "Taco Bell Acwort...")]

        public void ShouldParse(string str, double latitude,double longitude,string name)
        {
            //Arrange
            TacoParser sut = new TacoParser();
            
            

            // act
           
            var actual = sut.Parse(str);

            //assert
            Assert.Equal(latitude, actual.Location.Latitude);
            Assert.Equal(longitude, actual.Location.Longitude);
            Assert.Equal(name, actual.Name);




            // TODO: Complete Should Parse
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ShouldFailParse(string str)
        {
            TacoParser sut = new TacoParser(); //arrange
            var actual = sut.Parse(str);//act
            Assert.Null(actual);

        }
    }       
}
