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
                 "id" : 1,
                 "resource_state" : 3,
                 "name" : "Team Strava Cycling",
                 "profile_medium" : "https://dgalywyr863hv.cloudfront.net/pictures/clubs/1/1582/4/medium.jpg",
                 "profile" : "https://dgalywyr863hv.cloudfront.net/pictures/clubs/1/1582/4/large.jpg",
                 "cover_photo" : "https://dgalywyr863hv.cloudfront.net/pictures/clubs/1/4328276/1/large.jpg",
                 "cover_photo_small" : "https://dgalywyr863hv.cloudfront.net/pictures/clubs/1/4328276/1/small.jpg",
                 "sport_type" : "cycling",
                 "activity_types" : [ "Ride", "VirtualRide", "EBikeRide", "Velomobile", "Handcycle" ],
                 "city" : "San Francisco",
                 "state" : "California",
                 "country" : "United States",
                 "private" : true,
                 "member_count" : 116,
                 "featured" : false,
                 "verified" : false,
                 "url" : "team-strava-bike",
                 "membership" : "member",
                 "admin" : false,
                 "owner" : false,
                 "description" : "Private club for Cyclists who work at Strava.",
                 "club_type" : "company",
                 "post_count" : 29,
                 "owner_id" : 759,
                 "following_count" : 107
               }
               """;

//GetMissingJsonProperties<IEnumerable<SummaryActivityResponseModel>>(json);

var result = JsonConvert.DeserializeObject<DetailedClubResponseModel>(json)!;


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