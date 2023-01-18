using Newtonsoft.Json;


namespace MVCProject.Extensions
{
    
    /// <summary>
    /// truc trouvé sur internet pour sauvegarder des objets complexes en session probablement pas the way to go
    /// </summary>
    public static class SessionExtensions
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObject<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
