using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using Weather.Core.Model;

namespace Weather.Core.Service
{
    public class WeatherService
    {
        public CurrentWeatherTrackModel GetCurrentWeather(string countryName)
        {
            try
            {
                Uri uri = 
                    new Uri("http://api.openweathermap.org/data/2.5/weather?q=Yerevan&APPID=c211d557b8ee5db0e9a6d50e05f44a3e&units=metric");
                WebRequest webRequest = WebRequest.Create(uri);
                WebResponse response = webRequest.GetResponse();
                StreamReader streamReader = new StreamReader(response.GetResponseStream());
                String responseData = streamReader.ReadToEnd();

                var track = JsonConvert.DeserializeObject<CurrentWeatherTrackModel>(responseData);
                return track;

            }
            catch(Exception ex)
            {

                return null;
            }
        }

        public ForcastWeatherTrackModel GetForcasttWeather(string countryName)
        {
            try
            {
                Uri uri =
                    new Uri("http://api.openweathermap.org/data/2.5/forecast?q=Yerevan&APPID=c211d557b8ee5db0e9a6d50e05f44a3e&units=metric");
                WebRequest webRequest = WebRequest.Create(uri);
                WebResponse response = webRequest.GetResponse();
                StreamReader streamReader = new StreamReader(response.GetResponseStream());
                String responseData = streamReader.ReadToEnd();

                var track = JsonConvert.DeserializeObject<ForcastWeatherTrackModel>(responseData);
                return track;

            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
