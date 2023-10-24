using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace StravaClient
{
    /// <summary>
    /// 
    /// </summary>
    public class StravaClient
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="AccessToken"/> property
        /// </summary>
        private string? mAccessToken;
                
        /// <summary>
        /// The member of <see cref="ClientSecret"/> property
        /// </summary>
        private string? mClientSecret;
        
        /// <summary>
        /// The member of <see cref="RefreshToken"/> property
        /// </summary>
        private string? mRefreshToken;

        #endregion

        #region Public Properties

        /// <summary>
        /// The application’s ID, obtained during registration.
        /// </summary>
        public int ClientId { get; }

        /// <summary>
        /// The application’s secret, obtained during registration.
        /// </summary>
        [AllowNull]
        public string ClientSecret
        {
            get => mClientSecret ?? string.Empty;

            private set => mClientSecret = value;
        }

        /// <summary>
        /// The access token.
        /// </summary>
        [AllowNull]
        public string AccessToken
        {
            get => mAccessToken ?? string.Empty;

            private set => mAccessToken = value;
        }

        /// <summary>
        /// The refresh token.
        /// </summary>
        [AllowNull]
        public string RefreshToken
        {
            get => mRefreshToken ?? string.Empty;

            private set => mRefreshToken = value;
        }

        /// <summary>
        /// The expiration date of the key.
        /// </summary>
        public DateTimeOffset ExpiresAt { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        public StravaClient(int clientId, string clientSecret, string refreshToken, DateTimeOffset expiresAt, string? accessToken = null)
        {
            if (string.IsNullOrEmpty(clientSecret))
                throw new ArgumentException($"'{nameof(clientSecret)}' cannot be null or empty.", nameof(clientSecret));

            if (string.IsNullOrEmpty(refreshToken))
                throw new ArgumentException($"'{nameof(refreshToken)}' cannot be null or empty.", nameof(refreshToken));

            ClientId = clientId;
            ClientSecret = clientSecret;
            RefreshToken = refreshToken;
            ExpiresAt = expiresAt;
            AccessToken = accessToken;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<DetailedActivityResponseModel>>? AddActivityAsync(ActivityRequestModel model)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.PostAsync<DetailedActivityResponseModel>(GetRouteWithAPIKey(APIRoutes.ActivitiesRoute), model, null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<DetailedActivityResponseModel>> GetActivityByIdAsync(string id, ActivityByIdAPIArgs? args = null)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<DetailedActivityResponseModel>(GetRouteWithAPIKey(RouteHelpers.AttachParameters(APIRoutes.GetActivityRoute(id), args)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<IEnumerable<CommentResponseModel>>> GetCommentsByActivityIdAsync(string id, CommentsByActivityIdAPIArgs? args = null)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<IEnumerable<CommentResponseModel>>(GetRouteWithAPIKey(RouteHelpers.AttachParameters(APIRoutes.GetActivityAndCommentsRoute(id), args)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<IEnumerable<SummaryAthleteResponseModel>>> GetKudoersByActivityIdAsync(string id, KudoersByActivityIdAPIArgs? args = null)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<IEnumerable<SummaryAthleteResponseModel>>(GetRouteWithAPIKey(RouteHelpers.AttachParameters(APIRoutes.GetActivityAndKudosRoute(id), args)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<IEnumerable<LapResponseModel>>> GetLapsByActivityIdAsync(string id)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<IEnumerable<LapResponseModel>>(GetRouteWithAPIKey(APIRoutes.GetActivityAndLapsRoute(id)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<IEnumerable<SummaryAthleteResponseModel>>> GetAthleteActivitiesAsync(AthleteActivitiesAPIArgs? args = null)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<IEnumerable<SummaryAthleteResponseModel>>(GetRouteWithAPIKey(RouteHelpers.AttachParameters(APIRoutes.AthleteActivitiesRoute, args)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<IEnumerable<ActivityZoneResponseModel>>> GetZonesByActivityIdAsync(string id)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<IEnumerable<ActivityZoneResponseModel>>(GetRouteWithAPIKey(APIRoutes.GetActivityAndZonesRoute(id)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<DetailedActivityResponseModel>> UpdateActivityByIdAsync(string id, ActivityRequestModel model)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.PutAsync<DetailedActivityResponseModel>(GetRouteWithAPIKey(APIRoutes.PutActivityRoute(id)), model, null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<WebRequestResult<DetailedAthleteResponseModel>> GetAthleteAsync()
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<DetailedAthleteResponseModel>(GetRouteWithAPIKey(APIRoutes.AthleteRoute), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<WebRequestResult<IEnumerable<ZonesResponseModel>>> GetAthleteZonesAsync()
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<IEnumerable<ZonesResponseModel>>(GetRouteWithAPIKey(APIRoutes.GetAthleteAndZonesRoute), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<WebRequestResult<ActivityStatsResponseModel>> GetAthleteStatsAsync(string id)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<ActivityStatsResponseModel>(GetRouteWithAPIKey(APIRoutes.GetAthletesStatsRoute(id)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<WebRequestResult<DetailedAthleteResponseModel>> UpdateAthleteZonesAsync(string id)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.PutAsync<DetailedAthleteResponseModel>(GetRouteWithAPIKey(APIRoutes.PutAthleteRoute(id)), null, null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<IEnumerable<ClubActivityResponseModel>>> GetClubActivitiesByIdAsync(string id, ClubActivitiesByIdAPIArgs? args = null)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<IEnumerable<ClubActivityResponseModel>>(GetRouteWithAPIKey(RouteHelpers.AttachParameters(APIRoutes.GetClubsAndActivitiesRoute(id), args)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<IEnumerable<SummaryAthleteResponseModel>>> GetClubAdminsByIdAsync(string id, ClubAdminsByIdAPIArgs? args = null)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<IEnumerable<SummaryAthleteResponseModel>>(GetRouteWithAPIKey(RouteHelpers.AttachParameters(APIRoutes.GetClubsAndAdminsRoute(id), args)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<DetailedClubResponseModel>> GetClubsByIdAsync(string id)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<DetailedClubResponseModel>(GetRouteWithAPIKey(APIRoutes.GetClubsRoute(id)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<IEnumerable<ClubAthleteResponseModel>>> GetClubMembersByIdAsync(string id, ClubMembersByIdAPIArgs? args = null)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<IEnumerable<ClubAthleteResponseModel>>(GetRouteWithAPIKey(RouteHelpers.AttachParameters(APIRoutes.GetClubsAndMembersRoute(id), args)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<IEnumerable<SummaryClubResponseModel>>> GetClubsLoggedInAthleteAsync(ClubsLoggedInAthleteAPIArgs? args = null)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<IEnumerable<SummaryClubResponseModel>>(GetRouteWithAPIKey(RouteHelpers.AttachParameters(APIRoutes.AthleteAndClubsRoute, args)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<DetailedGearResponseModel>> GetGearByIdAsync(string id)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<DetailedGearResponseModel>(GetRouteWithAPIKey(APIRoutes.GetGearRoute(id)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<RouteResponseModel>> GetRouteByIdAsync(string id)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<RouteResponseModel>(GetRouteWithAPIKey(APIRoutes.GetRoutesRoute(id)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<IEnumerable<RouteResponseModel>>> GetRoutesByAthleteIdAsync(string id, RoutesByAthleteIdAPIArgs? args = null)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<IEnumerable<RouteResponseModel>>(GetRouteWithAPIKey(RouteHelpers.AttachParameters(APIRoutes.GetAthletesAndRoutesRoute(id), args)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<IEnumerable<DetailedSegmentEffortResponseModel>>> GetEffortsBySegmentIdAsync(EffortsBySegmentIdAPIArgs? args = null)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<IEnumerable<DetailedSegmentEffortResponseModel>>(GetRouteWithAPIKey(RouteHelpers.AttachParameters(APIRoutes.SegmentEffortsRoute, args)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<DetailedSegmentEffortResponseModel>> GetSegmentEffortByIdAsync(string id)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<DetailedSegmentEffortResponseModel>(GetRouteWithAPIKey(APIRoutes.GetSegmentEffortById(id)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<ExplorerResponseResponseModel>> GetExploreSegmentsAsync(SegmentsExploreAPIArgs? args = null)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<ExplorerResponseResponseModel>(GetRouteWithAPIKey(RouteHelpers.AttachParameters(APIRoutes.SegmentExlporeRoute, args)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<SummarySegmentResponseModel>> GetStarredSegmentsAsync(StarredSegmentsAPIArgs? args = null)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<SummarySegmentResponseModel>(GetRouteWithAPIKey(RouteHelpers.AttachParameters(APIRoutes.StarredSegmentsRoute, args)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<DetailedSegmentResponseModel>> GetSegmentByIdAsync(string id)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<DetailedSegmentResponseModel>(GetRouteWithAPIKey(APIRoutes.SegmentByIdRoute(id)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<DetailedSegmentResponseModel>> UpdateStarSegment(string id)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.PutAsync<DetailedSegmentResponseModel>(GetRouteWithAPIKey(APIRoutes.SegmentStar(id)), null, null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<IEnumerable<object>>> GetActivityStreamsAsync(string id, ActivityStreamsAPIArgs? args = null)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<IEnumerable<object>>(GetRouteWithAPIKey(RouteHelpers.AttachParameters(APIRoutes.GetActivitiesAndStreamsRoute(id), args)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<IEnumerable<object>>> GetRouteStreamsAsync(string id)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<IEnumerable<object>>(GetRouteWithAPIKey(APIRoutes.GetRoutesAndStreamsRoute(id)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<IEnumerable<object>>> GetSegmentEffortsStreamsAsync(string id, SegmentEffortStreamsAPIArgs? args = null)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<IEnumerable<object>>(GetRouteWithAPIKey(RouteHelpers.AttachParameters(APIRoutes.GetSegmentEffortAndStreamsRoute(id), args)), null);
            });
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<IEnumerable<object>>> GetSegmentStreamsAsync(string id, SegmentStreamsAPIArgs? args = null)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<IEnumerable<object>>(GetRouteWithAPIKey(RouteHelpers.AttachParameters(APIRoutes.GetSegmentsAndStreamsRoute(id), args)), null);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uploadId"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<UploadResponseModel>> GetUploadsAsync(string uploadId)
        {
            return await GetNewAccessTokenAsync((authenticateToken) =>
            {
                return WebRequestsClient.Instance.GetAsync<UploadResponseModel>(GetRouteWithAPIKey(APIRoutes.GetUploadsRoute(uploadId)), null);
            });
        }

        #endregion

        #region Public Async Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="refreshToken"></param>
        /// <returns></returns>
        public async Task<WebRequestResult<RefreshTokenResponseModel>> RequestNewToken(int clientId, string clientSecret, string refreshToken)
        {
            // Get the access token
            var response = await WebRequestsClient.Instance.PostAsync<RefreshTokenResponseModel>(url:"", new RefreshTokenRequestModel(clientId, clientSecret, refreshToken)
            {
                ClientId = clientId,
                ClientSecret = clientSecret,
                RefreshToken = refreshToken
            }, null);

            // If the response is not successful...
            if (!response.IsSuccessful)
                return response.ToUnsuccessfulWebRequestResult<RefreshTokenResponseModel>();

            // Set the access token
            mAccessToken = response.Result.AccessToken;

            // Return
            return response;
        }

        #endregion

        #region Private Async Methods

        /// <summary>
        /// Attaches the <see cref="AccessToken"/> to the specified <paramref name="url"/>
        /// </summary>
        /// <param name="url">The URL</param>
        /// <returns></returns>
        private string GetRouteWithAPIKey(string url) => QueryHelpers.AddQueryString(url, "key", AccessToken);

        private async Task<WebRequestResult<T>> GetNewAccessTokenAsync<T>(Func<string, Task<WebRequestResult<T>>> action)
            where T : class
        {
            // If there isn't an access token
            if (string.IsNullOrEmpty(AccessToken) || ExpiresAt <= DateTimeOffset.Now)
            {
                // Gets the authentication token
                var authenticationResponse = await RequestNewToken(ClientId, ClientSecret, RefreshToken);

                // If the response is not successful...
                if (!authenticationResponse.IsSuccessful)
                    return new WebRequestResult<T>() { ErrorMessage = authenticationResponse.ErrorMessage };

                // Sets the authentication token
                AccessToken = authenticationResponse.Result.AccessToken;

                // Sets the refresh token
                RefreshToken = authenticationResponse.Result.RefreshToken;

                // Sets the expiration date of the token
                ExpiresAt = authenticationResponse.Result.ExpiresAt;
            }

            // Execute the action
            var response = await action(AccessToken);

            // If the response is not successful...
            if (!response.IsSuccessful && response.StatusCode == HttpStatusCode.Unauthorized)
            {
                // Gets the authentication token
                var authenticationResponse = await RequestNewToken(ClientId, ClientSecret, RefreshToken);

                // If the response is not successful...
                if (!authenticationResponse.IsSuccessful)
                    return authenticationResponse.ToUnsuccessfulWebRequestResult<T>();

                // Sets the authentication token
                AccessToken = authenticationResponse.Result.AccessToken;

                // Execute the action
                response = await action(AccessToken);
            }

            return response;
        }

        #endregion
    }
}