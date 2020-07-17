using System;

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();

        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Do not fail if one record parsing fails, return null
            // TODO Implement

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                return null;
                // Log that and return null
            }


            // grab the latitude from your array at index 0

            double lat = double.Parse(cells[0]);
            // grab the longitude from your array at index 1
            double longitude = double.Parse(cells[1]);

            // grab the name from your array at index 2
            string name = cells[2];

            //Done// Your going to need to parse your string as a `double`

            //Done //Done// which is similar to parsing a string as an `int`

            //DONE // You'll need to create a TacoBell class
            //DONE  // that conforms to ITrackable

            //DONE   // Then, you'll need an instance of the TacoBell class
            //DONE   // With the name and point set correctly
            TacoBell taco = new TacoBell();
            taco.Name = name;
            taco.Location = new Point()
            {
                Latitude = lat,
                Longitude = longitude

            };




            return taco;
          //DONE  // Then, return the instance of your TacoBell class
        //DONE   // Since it conforms to ITrackable
        }
    }
}