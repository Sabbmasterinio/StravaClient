namespace StravaClient
{
    public static class APIRoutes
    {
        public const string BaseRoute = "https://www.strava.com/api/v3";

        public const string ActivitiesRoute = $"/activities";

        public static string GetActivityRoute(string id) => $"{ActivitiesRoute}/{id}";

        public static string GetActivityAndCommentsRoute(string id) => $"{ActivitiesRoute}/{id}/comments";

        public static string GetActivityAndKudosRoute(string id) => $"{ActivitiesRoute}/{id}/kudos";

        public static string GetActivityAndLapsRoute(string id) => $"{ActivitiesRoute}/{id}/laps";

        public const string AthleteActivitiesRoute = $"{AthleteRoute}{ActivitiesRoute}";

        public static string GetActivityAndZonesRoute(string id) => $"{ActivitiesRoute}/{id}/zones";

        public static string PutActivityRoute(string id) => $"{ActivitiesRoute}/{id}";
        
        public const string AthleteRoute = "/athlete";

        public const string GetAthleteAndZonesRoute = $"{AthleteRoute}/zones";

        public static string GetAthletesStatsRoute(string id) => $"{AthleteRoute}s/{id}/stats";

        public static string PutAthleteRoute(string id) => $"{AthleteRoute}";

        public const string ClubsRoute = "/clubs";

        public static string GetClubsAndActivitiesRoute(string id) => $"{ClubsRoute}/{id}{ActivitiesRoute}";

        public static string GetClubsAndAdminsRoute(string id) => $"{ClubsRoute}/{id}/admins";

        public static string GetClubsRoute(string id) => $"{ClubsRoute}/{id}";

        public static string GetClubsAndMembersRoute(string id) => $"{ClubsRoute}/{id}/members";

        public const string AthleteAndClubsRoute = $"{AthleteRoute}{ClubsRoute}";

        public static string GetGearRoute(string id) => $"/gear/{id}";

        public const string RoutesRoute = "/routes";

        public static string GetRoutesExportGpxRoute(string id) => $"{RoutesRoute}/{id}/export_gpx";

        public static string GetRoutesExportTcxRoute(string id) => $"{RoutesRoute}/{id}/export_tcx";

        public static string GetRoutesRoute(string id) => $"{RoutesRoute}/{id}";

        public static string GetAthletesAndRoutesRoute(string id) => $"{AthleteRoute}/{id}{RoutesRoute}";

        public const string SegmentEffortsRoute = $"/segment_efforts";

        public static string GetSegmentEffortById(string id) => $"{SegmentEffortsRoute}/{id}";

        public const string SegmentExlporeRoute = $"/segments/explore";

        public const string StarredSegmentsRoute = $"/segments/starred";

        public static string SegmentStar(string id) => $"/segments/{id}/starred";

        public static string SegmentByIdRoute(string id) => $"/segments/{id}";

        public const string StreamsRoute = "/streams";

        public static string GetActivitiesAndStreamsRoute(string id) => $"{ActivitiesRoute}/{id}{StreamsRoute}";

        public static string GetRoutesAndStreamsRoute(string id) => $"{RoutesRoute}/{id}{StreamsRoute}";

        public static string GetSegmentEffortAndStreamsRoute(string id) => $"/segment_efforts/{id}{StreamsRoute}";

        public static string GetSegmentsAndStreamsRoute(string id) => $"/segments/{id}{StreamsRoute}";

        public const string UploadsRoute = "/uploads";

        public static string GetUploadsRoute(string uploadId) => $"{UploadsRoute}/{uploadId}";
    }
}