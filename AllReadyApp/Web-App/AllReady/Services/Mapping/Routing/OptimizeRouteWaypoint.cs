﻿using System;

namespace AllReady.Services.Mapping.Routing
{
    /// <summary>
    /// Defines the propeties of a waypoint to be optimized
    /// </summary>
    public class OptimizeRouteWaypoint
    {
        /// <summary>
        /// Initializes a new instance of a <see cref="OptimizeRouteWaypoint"/>
        /// </summary>
        public OptimizeRouteWaypoint(double longitude, double latitude, Guid requestId)
        {
            Coordinates = string.Join(",", latitude.ToString(), longitude.ToString());
            RequestId = requestId;
        }

        /// <summary>
        /// The coordinates (lat/long) of the waypoint as comma seperated values
        /// </summary>
        public string Coordinates { get; }

        /// <summary>
        /// The ID of the request that the waypoint represents
        /// </summary>
        public Guid RequestId { get; }
    }
}