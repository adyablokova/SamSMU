using System;

namespace TubeRace
{
    /// <summary>
    /// This parameter defines current game status: started, paused, destroyed and winner.
    /// </summary>
    [Serializable]
    public enum SpaceShipGameStatus
    {
        /// <summary>
        /// Game status: Started.
        /// </summary>
        Started,
        /// <summary>
        /// Game status:Paused.
        /// </summary>
        Paused,
        /// <summary>
        /// Game status: Destroyed.
        /// </summary>
        Destroyed,
        /// <summary>
        /// Game status: Winner
        /// </summary>
        Winner
    };
}