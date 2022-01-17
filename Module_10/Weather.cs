using System;

namespace Module_10
{
    /// <summary>
    /// Класс погоды,поля и его методы
    /// </summary>
    public class Weather
    {
        public string NameCity { get; private set; }
        public double TempCity { get; private set; }
        public double MinTempCity { get; private set; }
        public double MaxTempCity { get; private set; }
        public double LonCity { get; private set; }
        public double LatCity { get; private set; }
        public DateTime Datetime { get; private set; }

        public Weather(string nameCity, double tempCity, double minTempCity, double maxTempCity, double lonCity,double latCity, DateTime dateTime)
        {
            NameCity = nameCity;
            TempCity = tempCity;
            MinTempCity = minTempCity;
            MaxTempCity = maxTempCity;
            LonCity = lonCity;
            LatCity = latCity;
            Datetime = dateTime;
        }

        public Weather(string nameCity, double tempCity, double minTempCity, double maxTempCity, double templonCity, double templatCity) :
            this(nameCity, tempCity, minTempCity, maxTempCity, templonCity, templatCity, new DateTime())
        {
            Datetime = DateTime.Now;
        }
    }
}
