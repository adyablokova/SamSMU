using System;

namespace TubeRace
{
    /// <summary>
    /// This enum defines the type of weapon selected: cubic, capsule, spherical and cylindrical.
    /// </summary>
    [Serializable]
    public enum SpaceShipWeapon
    {
        /// <summary>
        /// Cubic weapon.
        /// </summary>
        Cube,
        /// <summary>
        /// Spherical weapon.
        /// </summary>
        Sphere,
        /// <summary>
        /// Capsule weapon.
        /// </summary>
        Capsule,
        /// <summary>
        /// Cylindrical weapon.
        /// </summary>
        Cylinder
    };
}