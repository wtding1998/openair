﻿namespace Env.CnemcPublish.DAL
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using OpenRiaServices.DomainServices.Client;

    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/Env.CnemcPublish.DAL")]
    public sealed class CityAQIPublishHistory : Entity
    {
        private string _aqi;
        private string _area;
        private int _cityCode;
        private string _co;
        private int _id;
        private string _measure;
        private string _no2;
        private string _o3;
        private string[] _openAccessGenerated;
        private string _pm10;
        private string _pm2_5;
        private string _primaryPollutant;
        private string _quality;
        private string _so2;
        private DateTime _timePoint;
        private string _unheathful;

        public override object GetIdentity()
        {
            return this._id;
        }

        [StringLength(5), DataMember, RoundtripOriginal]
        public string AQI
        {
            get
            {
                return this._aqi;
            }
            set
            {
                if (this._aqi != value)
                {
                    base.RaiseDataMemberChanging("AQI");
                    base.ValidateProperty("AQI", value);
                    this._aqi = value;
                    base.RaiseDataMemberChanged("AQI");
                }
            }
        }

        [RoundtripOriginal, StringLength(50), DataMember]
        public string Area
        {
            get
            {
                return this._area;
            }
            set
            {
                if (this._area != value)
                {
                    base.RaiseDataMemberChanging("Area");
                    base.ValidateProperty("Area", value);
                    this._area = value;
                    base.RaiseDataMemberChanged("Area");
                }
            }
        }

        [RoundtripOriginal, DataMember]
        public int CityCode
        {
            get
            {
                return this._cityCode;
            }
            set
            {
                if (this._cityCode != value)
                {
                    base.RaiseDataMemberChanging("CityCode");
                    base.ValidateProperty("CityCode", value);
                    this._cityCode = value;
                    base.RaiseDataMemberChanged("CityCode");
                }
            }
        }

        [RoundtripOriginal, StringLength(8), DataMember]
        public string CO
        {
            get
            {
                return this._co;
            }
            set
            {
                if (this._co != value)
                {
                    base.RaiseDataMemberChanging("CO");
                    base.ValidateProperty("CO", value);
                    this._co = value;
                    base.RaiseDataMemberChanged("CO");
                }
            }
        }

        [Editable(false, AllowInitialValue=true), RoundtripOriginal, DataMember, Key]
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (this._id != value)
                {
                    base.ValidateProperty("Id", value);
                    this._id = value;
                    base.RaisePropertyChanged("Id");
                }
            }
        }

        [StringLength(0xff), DataMember, RoundtripOriginal]
        public string Measure
        {
            get
            {
                return this._measure;
            }
            set
            {
                if (this._measure != value)
                {
                    base.RaiseDataMemberChanging("Measure");
                    base.ValidateProperty("Measure", value);
                    this._measure = value;
                    base.RaiseDataMemberChanged("Measure");
                }
            }
        }

        [RoundtripOriginal, StringLength(5), DataMember]
        public string NO2
        {
            get
            {
                return this._no2;
            }
            set
            {
                if (this._no2 != value)
                {
                    base.RaiseDataMemberChanging("NO2");
                    base.ValidateProperty("NO2", value);
                    this._no2 = value;
                    base.RaiseDataMemberChanged("NO2");
                }
            }
        }

        [DataMember, StringLength(5), RoundtripOriginal]
        public string O3
        {
            get
            {
                return this._o3;
            }
            set
            {
                if (this._o3 != value)
                {
                    base.RaiseDataMemberChanging("O3");
                    base.ValidateProperty("O3", value);
                    this._o3 = value;
                    base.RaiseDataMemberChanged("O3");
                }
            }
        }

        [RoundtripOriginal, DataMember, Display(AutoGenerateField=false, AutoGenerateFilter=false, Description="OpenAccess Key", Name="-ID-"), Editable(false), ReadOnly(true)]
        public string[] OpenAccessGenerated
        {
            get
            {
                return this._openAccessGenerated;
            }
            set
            {
                if (this._openAccessGenerated != value)
                {
                    base.ValidateProperty("OpenAccessGenerated", value);
                    this._openAccessGenerated = value;
                    base.RaisePropertyChanged("OpenAccessGenerated");
                }
            }
        }

        [RoundtripOriginal, StringLength(5), DataMember]
        public string PM10
        {
            get
            {
                return this._pm10;
            }
            set
            {
                if (this._pm10 != value)
                {
                    base.RaiseDataMemberChanging("PM10");
                    base.ValidateProperty("PM10", value);
                    this._pm10 = value;
                    base.RaiseDataMemberChanged("PM10");
                }
            }
        }

        [RoundtripOriginal, StringLength(5), DataMember]
        public string PM2_5
        {
            get
            {
                return this._pm2_5;
            }
            set
            {
                if (this._pm2_5 != value)
                {
                    base.RaiseDataMemberChanging("PM2_5");
                    base.ValidateProperty("PM2_5", value);
                    this._pm2_5 = value;
                    base.RaiseDataMemberChanged("PM2_5");
                }
            }
        }

        [RoundtripOriginal, DataMember, StringLength(0xff)]
        public string PrimaryPollutant
        {
            get
            {
                return this._primaryPollutant;
            }
            set
            {
                if (this._primaryPollutant != value)
                {
                    base.RaiseDataMemberChanging("PrimaryPollutant");
                    base.ValidateProperty("PrimaryPollutant", value);
                    this._primaryPollutant = value;
                    base.RaiseDataMemberChanged("PrimaryPollutant");
                }
            }
        }

        [DataMember, RoundtripOriginal, StringLength(0xff)]
        public string Quality
        {
            get
            {
                return this._quality;
            }
            set
            {
                if (this._quality != value)
                {
                    base.RaiseDataMemberChanging("Quality");
                    base.ValidateProperty("Quality", value);
                    this._quality = value;
                    base.RaiseDataMemberChanged("Quality");
                }
            }
        }

        [StringLength(5), DataMember, RoundtripOriginal]
        public string SO2
        {
            get
            {
                return this._so2;
            }
            set
            {
                if (this._so2 != value)
                {
                    base.RaiseDataMemberChanging("SO2");
                    base.ValidateProperty("SO2", value);
                    this._so2 = value;
                    base.RaiseDataMemberChanged("SO2");
                }
            }
        }

        [RoundtripOriginal, ConcurrencyCheck, DataMember]
        public DateTime TimePoint
        {
            get
            {
                return this._timePoint;
            }
            set
            {
                if (this._timePoint != value)
                {
                    base.RaiseDataMemberChanging("TimePoint");
                    base.ValidateProperty("TimePoint", value);
                    this._timePoint = value;
                    base.RaiseDataMemberChanged("TimePoint");
                }
            }
        }

        [StringLength(0xff), DataMember, RoundtripOriginal]
        public string Unheathful
        {
            get
            {
                return this._unheathful;
            }
            set
            {
                if (this._unheathful != value)
                {
                    base.RaiseDataMemberChanging("Unheathful");
                    base.ValidateProperty("Unheathful", value);
                    this._unheathful = value;
                    base.RaiseDataMemberChanged("Unheathful");
                }
            }
        }
    }
}

