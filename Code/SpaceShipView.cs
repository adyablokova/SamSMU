using UnityEngine;

namespace TubeRace
{
    /// <summary>
    /// The view renders presentation of the Spaceship in a particular format.
    /// </summary>
    public class SpaceShipView : MonoBehaviour
    {
        /// <summary>
        /// In this game scenario this method sets View via status, parameters, tweaks and weapon.
        /// </summary>
        /// <param name="status">Status parameter is taken from SpaceShip class instance.</param>
        /// <param name="parameters">The argument Parameters is taken from SpaceShip class instance.</param>
        /// <param name="tweaks">Tweaks parameter is taken from SpaceShip class instance.</param>
        /// <param name="selectedWeapon">Weapon parameter is taken from SpaceShip class instance.</param>
        public void SetupView
        (
            SpaceShipGameStatus status,
            SpaceShipParameters parameters,
            SpaceShipTweaks tweaks,
            SpaceShipWeapon selectedWeapon
        )
        {
            Debug.Log($"Status = {status}");
            Debug.Log($"Parameters = {parameters}; Tweaks = {tweaks}");
            Debug.Log($"Selected weapon = {selectedWeapon}");
        }
    };
}