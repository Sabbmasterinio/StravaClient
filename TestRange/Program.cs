﻿// See https://aka.ms/new-console-template for more information
using StravaClient;
using System.Collections.Immutable;
using System.Net.Http.Headers;

var c = default(char);
var f = default(float);
var i = default(int);
var l = default(long);
var d = default(double);
var b = default(bool);
var ui = default(uint);
var by = default(byte);
var sh = default(short);
var sby = default(sbyte);
var dateTime = default(DateTime);
var dateTimeOffset = default(DateTimeOffset);
var dateOnly = default(DateOnly);
var timeOnly = default(TimeOnly);

var s = default(string);
var aT = default(ActivityTotalResponseModel);
var cA = default(ClubActivityResponseModel);

var nullableString = default(string?);
var nullableInt = default(int?);

var type = typeof(string);

var activityTotal = new ActivityTotalResponseModel();

var activityClub = new ClubActivityResponseModel()
{
};

activityClub.Athlete.Id = 10;

var id = activityClub.Athlete.Id;

activityClub.Name = null;

var name = activityClub.Name;

var length = name.Length;
var dictionary = new Dictionary<string, string>();
var heartRateZoneRangesResponseModel = new HeartRateZoneRangesResponseModel();

var zones = new List<ZoneRangeResponseModel>()
{
    new ZoneRangeResponseModel() { Min = 10, Max = 20 },
    new ZoneRangeResponseModel() { Min = 30, Max = 40 }
}.ToImmutableArray();

heartRateZoneRangesResponseModel.Zones = zones;

CreateResult(zones);

Console.ReadLine();

void CreateResult(IEnumerable<ZoneRangeResponseModel> zoneRanges)
{

}