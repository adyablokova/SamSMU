using UnityEngine;

namespace TubeRace
{
    /// <summary>
    /// Spaceship game object.
    /// </summary>
    public class SpaceShip : MonoBehaviour
    {
        /// <summary>
        /// This parameter defines current game status. For more info see <see cref="SpaceShipGameStatus"/>.
        /// </summary>
        [SerializeField]
        private SpaceShipGameStatus _gameStatus;

        /// <summary>
        /// Spaceship name. Commander instead of Han Solo is now Nastya.
        /// </summary>
        [ReadOnly]
        [SerializeField]
        private string _name = "Millennium Falcon";

        /// <summary>
        /// The game mission.
        /// </summary>
        [ReadOnly]
        [SerializeField]
        private string _mission = "Winning the Race";

        /// <summary>
        /// This parameter defines Spaceship options. For more info see <see cref="SpaceShipParameters"/>.
        /// </summary>
        [SerializeField]
        private SpaceShipParameters _parameters;

        /// <summary>
        /// This parameter defines Spaceship abillities. For more info see <see cref="SpaceShipTweaks"/>.
        /// </summary>
        [SerializeField]
        private SpaceShipTweaks _tweaks;

        /// <summary>
        /// This parameter defines selected weapon. For more info see <see cref="SpaceShipWeapon"/>.
        /// </summary>
        [Header("Weapons")]
        public SpaceShipWeapon _selectedWeapon;

        /// <summary>
        /// This parameter defines Spaceship view. The view renders presentation of the Spaceship in a particular format.
        /// For more info see <see cref="SpaceShipView"/>.
        /// </summary>
        [SerializeField]
        private SpaceShipView _view;

        /// <summary>
        /// Cubic weapon.
        /// </summary>
        [SerializeField]
        private GameObject _cubePerfab;

        /// <summary>
        /// Capsule weapon.
        /// </summary>
        [SerializeField]
        private GameObject _capsulePerfab;

        /// <summary>
        /// Spherical weapon.
        /// </summary>
        [SerializeField]
        private GameObject _spherePerfab;

        /// <summary>
        /// Cylindrical weapon.
        /// </summary>
        [SerializeField]
        private GameObject _cylinderPerfab;
                
        /// <summary>
        /// This metod works when the Spaceship is active just before the first call of any if the metods Update. 
        /// Start method is called once. In this game scenario the Start method sets View via status, parameters, tweaks and weapon.
        /// </summary>
        private void Start()
        {
            _view.SetupView(_gameStatus, _parameters, _tweaks, _selectedWeapon);
        }
        /// <summary>
        /// This method startes every frame of the game after activating the metod Start.
        /// In this game scenario if the space key code pressed the Spaceship attacks.
        /// </summary>
        private void Update()
        {
            if (!Input.GetKeyDown(KeyCode.Space)
                || _gameStatus != SpaceShipGameStatus.Started)
                return;

            GameObject perfab = null;

            switch (_selectedWeapon)
            {
                case SpaceShipWeapon.Cube:
                    perfab = _cubePerfab;
                    break;

                case SpaceShipWeapon.Sphere:
                    perfab = _spherePerfab;
                    break;

                case SpaceShipWeapon.Capsule:
                    perfab = _capsulePerfab;
                    break;

                case SpaceShipWeapon.Cylinder:
                    perfab = _cylinderPerfab;
                    break;
            }

            Instantiate(perfab);
        }
    };
}