using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net;

namespace Module_10
{
    public class Method
    {
        /// <summary>
        /// Метод получает название города и возвращает ссылку на него
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        public string City(string city) 
        {
            string tempurl = String.Empty;
            switch (city) 
            {
                case "Moscow": 
                    {
                        tempurl = @"http://api.openweathermap.org/data/2.5/weather?q=Moscow&units=metric&appid=fce39138fbef5f8c5d15cb37f6bd1c17";
                        break;
                    }
                case "Saint Petersburg":
                    {
                        tempurl = @"http://api.openweathermap.org/data/2.5/weather?lat=59.8944&lon=30.2642&units=metric&appid=fce39138fbef5f8c5d15cb37f6bd1c17";
                        break;
                    }
                case "Saransk":
                    {
                        tempurl = @"http://api.openweathermap.org/data/2.5/weather?q=Saransk&units=metric&appid=fce39138fbef5f8c5d15cb37f6bd1c17";
                        break;
                    }
                case "Saratov":
                    {
                        tempurl = @"http://api.openweathermap.org/data/2.5/weather?q=Saratov&units=metric&appid=fce39138fbef5f8c5d15cb37f6bd1c17";
                        break;
                    }
                case "Samara":
                    {
                        tempurl = @"http://api.openweathermap.org/data/2.5/weather?lat=53.2&lon=50.15&units=metric&appid=fce39138fbef5f8c5d15cb37f6bd1c17";
                        break;
                    }
                case "Novosibirsk":
                    {
                        tempurl = @"http://api.openweathermap.org/data/2.5/weather?q=Novosibirsk&units=metric&appid=fce39138fbef5f8c5d15cb37f6bd1c17";
                        break;
                    }
                case "Irkutsk":
                    {
                        tempurl = @"http://api.openweathermap.org/data/2.5/weather?q=Irkutsk&units=metric&appid=fce39138fbef5f8c5d15cb37f6bd1c17";
                        break;
                    }
            }
            return tempurl;
        }

        /// <summary>
        /// Метод получает ссылку, делает запрос на сайт и получает фаил Json, его же возвращает
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string RequestWebsite(string url)
        {
            string tempStringJson;
            using (var client = new WebClient())
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (StreamReader tempfile = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    tempStringJson = tempfile.ReadToEnd();
                }
            }

            return tempStringJson;
        }

        /// <summary>
        /// Метод получает фаил Json, делает десереализацию, возвращает два объект класса Weather 
        /// </summary>
        /// <param name="stringJson"></param>
        /// <param name="objweathers"></param>
        /// <param name="weather"></param>
        public void CreateJsonFile(string stringJson, out ObservableCollection<Weather> objweathers, out Weather weather)
        {
            ObservableCollection<Weather> tempobjweathers = new ObservableCollection<Weather>();

            var nameCity = (JObject.Parse(stringJson)["name"].ToString());
            var tempCity = Math.Round(double.Parse(JObject.Parse(stringJson)["main"]["temp"].ToString()));
            var tempMinCity = Math.Round(double.Parse(JObject.Parse(stringJson)["main"]["temp_min"].ToString()));
            var tempMaxCity = Math.Round(double.Parse(JObject.Parse(stringJson)["main"]["temp_max"].ToString()));
            var cordlonCity = double.Parse(JObject.Parse(stringJson)["coord"]["lon"].ToString());
            var cordlatCity = double.Parse(JObject.Parse(stringJson)["coord"]["lat"].ToString());

            weather = new Weather(nameCity, tempCity, tempMinCity, tempMaxCity, cordlonCity, cordlatCity); //Возврат значения для коллекции
            tempobjweathers.Add(new Weather(nameCity, tempCity, tempMinCity, tempMaxCity, cordlonCity, cordlatCity)); //Возврат значения для добавления в listview
            objweathers = tempobjweathers;
        }

        /// <summary>
        /// Метод формирования фаила Json, получает итоговую коллекцию, возвращает фаил Json
        /// </summary>
        /// <param name="weathers"></param>
        /// <returns></returns>
        public string SaveJsonFile(List<Weather> weathers) 
        {
            JArray jsonarray = new JArray();

            foreach (var item in weathers) 
            {
                JObject message = new JObject();
                JObject jsonobject1 = new JObject();
                JObject jsonobject2 = new JObject();

                message["message"] = jsonobject1;
                jsonobject1["city"] = item.NameCity;
                jsonobject1["date"] = item.Datetime;
                jsonobject1["coord"] = jsonobject2;
                jsonobject2["lon"] = item.LonCity;
                jsonobject2["lat"] = item.LatCity;

                jsonobject2 = new JObject();
                jsonobject1["temperature"] = jsonobject2;
                jsonobject2["current_temperature"] = item.TempCity;
                jsonobject2["min_temperature"] = item.MinTempCity;
                jsonobject2["max_temperature"] = item.MaxTempCity;

                jsonarray.Add(message);
            }
            return jsonarray.ToString();
        }
        
        /// <summary>
        /// Метод записи фаила на диск, получает сформированный Json
        /// </summary>
        /// <param name="file"></param>
        public void SaveFilePC(string file) 
        {
            DateTime dt = DateTime.Now;
            string strdt = dt.ToString(($"{dt:D}"));
            using (StreamWriter FileWeatherJson = new StreamWriter($"{strdt}.json",false))
            {
                FileWeatherJson.Write(file);
            }
        }
    }
}
