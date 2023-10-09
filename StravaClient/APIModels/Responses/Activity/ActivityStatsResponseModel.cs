using Newtonsoft.Json;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents activity stats.
    /// </summary>
    /// <remarks>A set of rolled-up statistics and totals for an athlete.</remarks>
    public class ActivityStatsResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="RecentRideTotals"/> property
        /// </summary>
        private ActivityTotalResponseModel? mRecentRideTotals;
        
        /// <summary>
        /// The member of <see cref="RecentRunTotals"/> property
        /// </summary>
        private ActivityTotalResponseModel? mRecentRunTotals;
        
        /// <summary>
        /// The member of <see cref="RecentSwimTotals"/> property
        /// </summary>
        private ActivityTotalResponseModel? mRecentSwimTotals;
        
        /// <summary>
        /// The member of <see cref="YtdRideTotals"/> property
        /// </summary>
        private ActivityTotalResponseModel? mYtdRideTotals;
        
        /// <summary>
        /// The member of <see cref="YtdRunTotals"/> property
        /// </summary>
        private ActivityTotalResponseModel? mYtdRunTotals;
        
        /// <summary>
        /// The member of <see cref="YtdSwimTotals"/> property
        /// </summary>
        private ActivityTotalResponseModel? mYtdSwimTotals;
        
        /// <summary>
        /// The member of <see cref="AllRideTotals"/> property
        /// </summary>
        private ActivityTotalResponseModel? mAllRideTotals;
        
        /// <summary>
        /// The member of <see cref="AllRunTotals"/> property
        /// </summary>
        private ActivityTotalResponseModel? mAllRunTotals;
        
        /// <summary>
        /// The member of <see cref="AllSwimTotals"/> property
        /// </summary>
        private ActivityTotalResponseModel? mAllSwimTotals;

        #endregion

        #region Public Properties

        /// <summary>
        /// The longest distance ridden by the athlete.
        /// </summary>
        [JsonProperty("biggest_ride_distance")]
        public double BiggestRideDistance { get; set; }

        /// <summary>
        /// The highest climb ridden by the athlete.
        /// </summary>
        [JsonProperty("biggest_climb_elevation_gain")]
        public double BiggestClimbElevationGain { get; set; }

        /// <summary>
        /// The recent (last 4 weeks) ride stats for the athlete.
        /// </summary>
        [JsonProperty("recent_ride_totals")]
        public ActivityTotalResponseModel RecentRideTotals 
        { 
            get => mRecentRideTotals ??= new(); 
            set => mRecentRideTotals = value; 
        }

        /// <summary>
        /// The recent (last 4 weeks) run stats for the athlete.
        /// </summary>
        [JsonProperty("recent_run_totals")]
        public ActivityTotalResponseModel RecentRunTotals 
        { 
            get => mRecentRunTotals ??= new(); 
            set => mRecentRunTotals = value; 
        }
        
        /// <summary>
        /// The recent (last 4 weeks) swim stats for the athlete.
        /// </summary>
        [JsonProperty("recent_swim_totals")]
        public ActivityTotalResponseModel RecentSwimTotals 
        { 
            get => mRecentSwimTotals ??= new();
            set => mRecentSwimTotals = value; 
        }

        /// <summary>
        /// The year to date ride stats for the athlete.
        /// </summary>
        [JsonProperty("ytd_ride_totals")]
        public ActivityTotalResponseModel YtdRideTotals
        { 
            get => mYtdRideTotals ??= new();
            set => mYtdRideTotals = value; 
        }
        
        /// <summary>
        /// The year to date run stats for the athlete.
        /// </summary>
        [JsonProperty("ytd_run_totals")]
        public ActivityTotalResponseModel YtdRunTotals 
        { 
            get => mYtdRunTotals ??= new(); 
            set => mYtdRunTotals = value; 
        }
        
        /// <summary>
        /// The year to date swim stats for the athlete.
        /// </summary>
        [JsonProperty("ytd_swim_totals")]
        public ActivityTotalResponseModel YtdSwimTotals 
        { 
            get => mYtdSwimTotals ??= new(); 
            set => mYtdSwimTotals =value; 
        }

        /// <summary>
        /// The all time ride stats for the athlete.
        /// </summary>
        [JsonProperty("all_ride_totals")]
        public ActivityTotalResponseModel AllRideTotals 
        { 
            get => mAllRideTotals ??= new();
            set => mAllRideTotals = value;
        }
        
        /// <summary>
        /// The all time run stats for the athlete.
        /// </summary>
        [JsonProperty("all_run_totals")]
        public ActivityTotalResponseModel AllRunTotals 
        {
            get => mAllRunTotals ??= new();
            set => mAllRunTotals =value;
        }
        
        /// <summary>
        /// The all time swim stats for the athlete.
        /// </summary>
        [JsonProperty("all_swim_totals")]
        public ActivityTotalResponseModel AllSwimTotals 
        { 
            get => mAllSwimTotals ??= new();
            set => mAllSwimTotals = value; 
        }


        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ActivityStatsResponseModel() : base()
        {

        }
        #endregion

        #region Public Methods

        #endregion
    }

}