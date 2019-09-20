// This file is part of the TI.DigitalDomeWorks project
// 
// Copyright © 2015-2016 Tigra Networks., all rights reserved.
// 
// File: TrafficLights.cs  Last modified: 2016-09-12@23:15 by Tim Long

namespace TA.WinFormsControls
    {
    /// <summary>
    ///     The TrafficLight enumeration may be used in any situation where a Normal/Warning/Error status indication is
    ///     needed.
    /// </summary>
    public enum TrafficLight
        {
        /// <summary>
        ///     Green traffic light represents a good or normal status.
        /// </summary>
        Green,

        /// <summary>
        ///     Yellow traffic light represents a warning condition, which does not necessarily prevent continued
        ///     operation but which merits further investigation.
        /// </summary>
        Yellow,

        /// <summary>
        ///     Red traffic light represents an error condition or a situation that prevents further progress.
        /// </summary>
        Red
        }
    }