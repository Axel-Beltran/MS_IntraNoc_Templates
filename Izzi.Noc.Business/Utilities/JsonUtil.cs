using Newtonsoft.Json;
namespace Izzi.Noc.Business.Utilities
{
    public static class JsonUtil
    {
        public static string SerializeJson<T>(T t)
        {
            return JsonConvert.SerializeObject(t);
        }
        public static T DeserializeJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}