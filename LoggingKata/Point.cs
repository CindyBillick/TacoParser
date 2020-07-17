namespace LoggingKata
{
    public struct Point
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public Point(double longitude, double lat) 
        {
            Latitude = lat;
            Longitude = longitude;
        }

    }
}