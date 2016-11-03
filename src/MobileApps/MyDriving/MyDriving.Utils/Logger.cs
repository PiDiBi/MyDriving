// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for details.

using System;
using System.Collections.Generic;
using MyDriving.Utils.Interfaces;
using System.Collections;
using System.Threading.Tasks;

namespace MyDriving.Utils
{
    public class Logger : ILogger
    {
        static ILogger _instance;
        public static string HockeyAppiOS => "d7be62df4e434d4caabaab06a10a0ce1 ";
        public static string HockeyAppAndroid => "84cffbdc953c4830b506a0f7f2393337";
        public static string HockeyAppUWP => "2c244ebe15274cca9fd222afa8583f8f";
        /// <summary>
        /// You can generate a key from: www.bingmapsportal.com
        /// This enables maps to show on the Past Trips screen
        /// </summary>
        public static string BingMapsAPIKey => "kOkHyZUptqPODTVFeozL~GKcF-fyslR6uINfG8RmwqA~AqhuayS67kocLCX1G0qJkJUj-mO2mLB93tMpnKlnmJnts_r6ZEGTszdV9QuCIjYK";

        public static ILogger Instance => _instance ?? (_instance = ServiceLocator.Instance.Resolve<ILogger>());

        #region ILogger implementation

        public virtual void Identify(string uid, IDictionary<string, string> table = null)
        {
          
        }

        public virtual void Identify(string uid, string key, string value)
        {
            
        }

        public virtual void Track(string trackIdentifier, IDictionary<string, string> table = null)
        {
           
        }

        public virtual void Track(string trackIdentifier, string key, string value)
        {
           
        }

        public virtual ITrackHandle TrackTime(string identifier, IDictionary<string, string> table = null)
        {
            return null;
        }

        public virtual ITrackHandle TrackTime(string identifier, string key, string value)
        {
            return null;

        }

        public virtual void Report(Exception exception)
        {
 
        }

        public virtual Task Save()
        {
            return Task.FromResult(true);
        }

        public virtual Task PurgePendingCrashReports()
        {
            return Task.FromResult(true);
        }

        

        #endregion
    }
    
}