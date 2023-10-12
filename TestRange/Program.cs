// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using StravaClient;
using System.Collections.Immutable;
using System.Net.Http.Headers;
using System.Reflection;

Console.WriteLine(  nameof(StravaClientConstants.ResourceStateToIntMapper));

var json = $$$"""
               {
                 "id" : 1234567890987654321,
                 "username" : "marianne_t",
                 "resource_state" : 3,
                 "firstname" : "Marianne",
                 "lastname" : "Teutenberg",
                 "city" : "San Francisco",
                 "state" : "CA",
                 "country" : "US",
                 "sex" : "F",
                 "premium" : true,
                 "created_at" : "2017-11-14T02:30:05Z",
                 "updated_at" : "2018-02-06T19:32:20Z",
                 "badge_type_id" : 4,
                 "profile_medium" : "https://xxxxxx.cloudfront.net/pictures/athletes/123456789/123456789/2/medium.jpg",
                 "profile" : "https://xxxxx.cloudfront.net/pictures/athletes/123456789/123456789/2/large.jpg",
                 "friend" : null,
                 "follower" : null,
                 "follower_count" : 5,
                 "friend_count" : 5,
                 "mutual_friend_count" : 0,
                 "athlete_type" : 1,
                 "date_preference" : "02/15/1999",
                 "measurement_preference" : "feet",
                 "clubs" : [ ],
                 "ftp" : null,
                 "weight" : 0,
                 "bikes" : [ {
                   "id" : "b12345678987655",
                   "primary" : true,
                   "name" : "EMC",
                   "resource_state" : 2,
                   "distance" : 0
                 } ],
                 "shoes" : [ {
                   "id" : "g12345678987655",
                   "primary" : true,
                   "name" : "adidas",
                   "resource_state" : 2,
                   "distance" : 4904
                 } ]
               }
               """;

GetMissingJsonProperties<DetailedAthleteResponseModel>(json);

var result = JsonConvert.DeserializeObject<DetailedAthleteResponseModel>(json)!;

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