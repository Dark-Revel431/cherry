namespace cherry.json.boot;

internal class Json
{
    internal static JsonData? ParseBoot(string @string)
    {
        return JsonConvert.DeserializeObject<JsonData>(@string);
    }
}
