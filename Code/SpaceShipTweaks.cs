using System;
using UnityEngine;

namespace TubeRace
{
    /// <summary>
    /// This class defines Spaceship attributes: current speed, hyperdrive, disguise, altitude, latitude and longitude.
    /// </summary>
    [Serializable]
    public class SpaceShipTweaks
    {
        /// <summary>
        /// This parameter defines current speed.
        /// </summary>
        [Range(0.0f, 300000.0f)]
        public float CurrentSpeed;

        /// <summary>
        /// This parameter defines the start and shutdown of the hyperdrive.
        /// </summary>
        public bool Hyperdrive;

        /// <summary>
        /// This parameter defines the start and shutdown of the disguise.
        /// </summary>
        public bool Disguise;

        /// <summary>
        /// This parameter defines the altitude of the Spaceship.
        /// </summary>
        [Range(0.0f, 1000.0f)]
        public float Altitude;

        /// <summary>
        /// This parameter defines the latitude of the Spaceship.
        /// </summary>
        [Range(0.0f, 1000.0f)]
        public float Latitude;

        /// <summary>
        /// This parameter defines the longitude of the Spaceship.
        /// </summary>
        [Range(0.0f, 1000.0f)]
        public float Longitude;
    };
}