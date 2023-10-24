// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using StravaClient;
using System;
using System.Collections.Immutable;
using System.Net.Http.Headers;
using System.Reflection;
using static System.Net.WebRequestMethods;
using System.Xml.Linq;
using System.Diagnostics;

//using var client = new HttpClient();
//client.BaseAddress = new Uri(url);

//// Configure OAuth2 access token for authorization: strava_oauth
//Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

//var apiInstance = new ActivitiesApi();
//var name = name_example;  // String | The name of the activity.
//var sportType = sportType_example;  // String | Sport type of activity. For example - Run, MountainBikeRide, Ride, etc.
//var startDateLocal = 2013 - 10 - 20T19: 20:30 + 01:00;  // Date | ISO 8601 formatted date time.
//var elapsedTime = 56;  // Integer | In seconds.
//var type = type_example;  // String | Type of activity. For example - Run, Ride etc. (optional) 
//var description = description_example;  // String | Description of the activity. (optional) 
//var distance = 3.4;  // Float | In meters. (optional) 
//var trainer = 56;  // Integer | Set to 1 to mark as a trainer activity. (optional) 
//var commute = 56;  // Integer | Set to 1 to mark as commute. (optional) 

//try
//{
//    // Create an Activity
//    DetailedActivity result = apiInstance.createActivity(name, sportType, startDateLocal, elapsedTime, type, description, distance, trainer, commute);
//    Debug.WriteLine(result);
//}
//catch (Exception e)
//{
//    Debug.Print("Exception when calling ActivitiesApi.createActivity: " + e.Message);
//}

Console.WriteLine(  nameof(StravaClientConstants.ResourceStateToIntMapper));

var json = $$$"""
               [
               {
                 "type": "latlng",
                 "data": [
                   [
                     37.833112,
                     -122.483436
                   ],
                   [
                     37.832964,
                     -122.483406
                   ]
                 ],
                 "series_type": "distance",
                 "original_size": 2,
                 "resolution": "high"
               }
               ]
               """;
//GetMissingJsonProperties<BaseEnumerableDataStreamResponseModel<float>>(json);

var result = JsonConvert.DeserializeObject<IEnumerable<CoordinatesStreamResponseModel>>(json)!;


var apiKey = await System.IO.File.ReadAllTextAsync(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "GoogleMapsAPIKey.txt"));

//var client = new GoogleMapsClient.GoogleMapsClient(apiKey);

//var placesResult = await client.NearbySearchAsync(new NearbySearchAPIArgs(new Coordinates(40.629269, 22.947412), 1500)
//{

//    Keyword = "restaurant"

//});


json = JsonConvert.SerializeObject(result);

//if (result.IsCommute)
//{
//
//}

Console.ReadLine();

int CountPropertiesOfJson(string json)
{
    var r = (JObject)JsonConvert.DeserializeObject(json)!;

    return r.Count;
}

int CountPropertiesOfType<T>()
{
    return typeof(T).GetProperties().Length;
}

IEnumerable<string> GetMissingJsonProperties<T>(string json)
{
    var propertiesOfType = typeof(T).GetProperties()
        .Select(x => x.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName)
        .Distinct()
        .Where(x => x is not null)
        .ToList();

    var missingProperties = new List<string>();

    foreach (var child in (JObject)JsonConvert.DeserializeObject(json)!)
    {
        if (!propertiesOfType.Contains(child.Key))
        {
            missingProperties.Add(child.Key);
        }
    }

    return missingProperties;
}


void GenerateMappings<T>()
    where T : struct, Enum
{
    var result = string.Empty;
    foreach(var enumValue in Enum.GetValues<T>())
    {
        result += "{ " + typeof(T).Name + "." + enumValue.ToString() + ", \"" + enumValue.ToString() + "\" }," + Environment.NewLine;
    }
}