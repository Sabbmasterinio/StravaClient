using Newtonsoft.Json;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a stream set.
    /// </summary>
    public class StreamSetResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Time"/> property
        /// </summary>
        private TimeStreamResponseModel? mTime;
        
        /// <summary>
        /// The member of <see cref="Distance"/> property
        /// </summary>
        private DistanceStreamResponseModel? mDistance;
        
        /// <summary>
        /// The member of <see cref="Latlng"/> property
        /// </summary>
        private LatLngStreamResponseModel? mLatlng;
        
        /// <summary>
        /// The member of <see cref="Altitude"/> property
        /// </summary>
        private AltitudeStreamResponseModel? mAltitude;
        
        /// <summary>
        /// The member of <see cref="VelocitySmooth"/> property
        /// </summary>
        private SmoothVelocityStreamResponseModel? mVelocitySmooth;
        
        /// <summary>
        /// The member of <see cref="Heartrate"/> property
        /// </summary>
        private HeartrateStreamResponseModel? mHeartrate;
        
        /// <summary>
        /// The member of <see cref="Cadence"/> property
        /// </summary>
        private CadenceStreamResponseModel? mCadence;
        
        /// <summary>
        /// The member of <see cref="Watts"/> property
        /// </summary>
        private PowerStreamResponseModel? mWatts;
        
        /// <summary>
        /// The member of <see cref="Temp"/> property
        /// </summary>
        private TemperatureStreamResponseModel? mTemp;
        
        /// <summary>
        /// The member of <see cref="Moving"/> property
        /// </summary>
        private MovingStreamResponseModel? mMoving;
        
        /// <summary>
        /// The member of <see cref="GradeSmooth"/> property
        /// </summary>
        private SmoothGradeStreamResponseModel? mGradeSmooth;

        #endregion

        #region Public Properties

        /// <summary>
        /// An instance of TimeStream.
        /// </summary>
        [JsonProperty("time")]
        public TimeStreamResponseModel Time 
        { 
            get => mTime ??= new();
            set => mTime = value;
        }
        
        /// <summary>
        /// An instance of DistanceStream.
        /// </summary>
        [JsonProperty("distance")]
        public DistanceStreamResponseModel Distance 
        { 
            get => mDistance ??= new();
            set => mDistance = value;
        }
        
        /// <summary>
        /// An instance of LatLngStream.
        /// </summary>
        [JsonProperty("latlng")]
        public LatLngStreamResponseModel Latlng 
        { 
            get => mLatlng ??= new();
            set => mLatlng = value;
        }
        
        /// <summary>
        /// An instance of AltitudeStream.
        /// </summary>
        [JsonProperty("altitude")]
        public AltitudeStreamResponseModel Altitude 
        { 
            get => mAltitude ??= new();
            set => mAltitude = value;
        }
        
        /// <summary>
        /// An instance of SmoothVelocityStream.
        /// </summary>
        [JsonProperty("velocity_smooth")]
        public SmoothVelocityStreamResponseModel VelocitySmooth 
        { 
            get => mVelocitySmooth ??= new();
            set => mVelocitySmooth = value;
        }
        
        /// <summary>
        /// An instance of HeratrateStream.
        /// </summary>
        [JsonProperty("heartrate")]
        public HeartrateStreamResponseModel Heartrate 
        { 
            get => mHeartrate ??= new();
            set => mHeartrate = value;
        }
        
        /// <summary>
        /// An instance of CadenceStream.
        /// </summary>
        [JsonProperty("cadence")]
        public CadenceStreamResponseModel Cadence 
        { 
            get => mCadence ??= new();
            set => mCadence = value;
        }
        
        /// <summary>
        /// An instance of PowerStream.
        /// </summary>
        [JsonProperty("watts")]
        public PowerStreamResponseModel Watts 
        { 
            get => mWatts ??= new();
            set => mWatts = value;
        }
        
        /// <summary>
        /// An instance of TemperatureStream.
        /// </summary>
        [JsonProperty("temp")]
        public TemperatureStreamResponseModel Temp
        { 
            get => mTemp ??= new();
            set => mTemp = value;
        }
        
        /// <summary>
        /// An instance of MovingStream.
        /// </summary>
        [JsonProperty("moving")]
        public MovingStreamResponseModel Moving
        { 
            get => mMoving ??= new();
            set => mMoving = value;
        }
        
        /// <summary>
        /// An instance of SmoothGradeStream.
        /// </summary>
        [JsonProperty("grade_smooth")]
        public SmoothGradeStreamResponseModel GradeSmooth
        { 
            get => mGradeSmooth ??= new();
            set => mGradeSmooth = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public StreamSetResponseModel() : base()
        {

        }

        #endregion
    }
}