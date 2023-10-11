// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using StravaClient;
using System.Collections.Immutable;
using System.Net.Http.Headers;


Console.WriteLine(  nameof(StravaClientConstants.ResourceStateToIntMapper));

var json = $$$"""
               [ {
                 "id" : 12345678987654321,
                 "activity_id" : 12345678987654321,
                 "post_id" : null,
                 "resource_state" : 3,
                 "text" : "Good job and keep the cat pictures coming!",
                 "mentions_metadata" : null,
                 "created_at" : "2018-02-08T19:25:39Z",
                 "athlete" : {
                   "firstname" : "Peter",
                   "lastname" : "S"
                 },
                 "cursor" : "abc123%20"
               } ]
               """;

var result = JsonConvert.DeserializeObject<IEnumerable<CommentResponseModel>>(json);

Console.ReadLine();

void GenerateMappings<T>()
    where T : struct, Enum
{
    var result = string.Empty;
    foreach(var enumValue in Enum.GetValues<T>())
    {
        result += "{ " + typeof(T).Name + "." + enumValue.ToString() + ", \"" + enumValue.ToString() + "\" }," + Environment.NewLine;
    }
}