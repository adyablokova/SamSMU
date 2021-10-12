using System;
using UnityEngine;

namespace TubeRace
{
    /// <summary>
    /// This class defines Spaceship options: mass, max speed and engine thrust.
    /// </summary>
    [Serializable]
    public class SpaceShipParameters
    {
        /// <summary>
        /// This parameter defines the mass of the Spaceship.
        /// </summary>
        public float Mass;

        /// <summary>
        /// This parameter defines the max speed of the Spaceship.
        /// </summary>
        [Range(0.0f, 300000.0f)]
        public float MaxSpeed;

        /// <summary>
        /// This parameter defines the engine thrust of the Spaceship.
        /// </summary>
        [Range(0.0f, 5000.0f)]
        public float EngineThrust;
    };
}