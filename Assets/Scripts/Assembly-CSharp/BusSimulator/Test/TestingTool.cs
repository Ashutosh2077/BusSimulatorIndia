using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BusSimulator.Test
{
	public class TestingTool : MonoBehaviour
	{
		[Header("Object Ref")]
		public GameObject teleportObj;

		public GameObject passengerObj;

		public GameObject timeObj;

		[Header("Teleport")]
		public Dropdown dropdownPortal;

		public Button getPortalButton;

		public Button goPortalButton;

		public List<Button> teleportButtons;

		public Button goToNextTargetButton;

		public Text goToNextTargetBuittonText;

		private ReachablePoint targetReachablePoint;

		public Button goToLastTargetButton;

		[Header("Crane Teleport")]
		public Button goToNextCraneButton;

		public Text goToNextCraneButtonText;

		private int cranePointId;

		[Header("Landmark Teleport")]
		public Button goToNextLandmarkButton;

		public Text goToNextLandmarkButtonText;

		private int landmarkPointId;

		[Header("SPBU Teleport")]
		public Button goToNextSpbuButton;

		public Text goToNextSpbuButtonText;

		private int spbuPointId;

		[Header("Carwash Teleport")]
		public Button goToNextCarwashButton;

		public Text goToNextCarwashButtonText;

		private int carwashPointId;

		[Header("Money")]
		public Button emptyMoneyButton;

		public Button addMoneyButton;

		[Header("Passenger")]
		public GameObject itemsContainer;

		public GameObject templatePrefab;

		public Dictionary<string, InputField> inputFields;

		[Header("Time")]
		public InputField timeInput;

		public Button timeChangeButton;

		public Button ggRefreshButton;

		public Button emptyFuelButton;

		[Header("Engine sounds")]
		public GameObject engineSounds;

		[Header("Dirt and Damage")]
		public Button damageButton;

		public Button dirtButton;

		[Header("Goto Places")]
		public Dropdown placesDropdown;

		private bool visible;

		private bool hudFloatVisible;

		private List<GameObject> targets;

		private static Database _database => null;

		private static PlayerController _playerController => null;

		private static PlayerVehicleBase _playerVehicle => null;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void UpdateGoToNextButton()
		{
		}

		private void OnGoToLastLocationClick()
		{
		}

		private void OnGoToNextButtonClick()
		{
		}

		private void OnGoToNextCraneButtonClick()
		{
		}

		private void OnGoToNextLandmarkButtonClick()
		{
		}

		private void OnGoToNextSpbuButtonClick()
		{
		}

		private void OnGoToNextCarwashButtonClick()
		{
		}

		private void Update()
		{
		}

		public void ToggleVisible()
		{
		}

		public void RefreshGoogleNativeAd()
		{
		}

		public void ToggleHUDFloat()
		{
		}

		public void ToggleBuildings()
		{
		}

		public void ToggleITS()
		{
		}

		public void ChangeTime()
		{
		}

		public void EmptyFuel()
		{
		}

		private void EmptyMoney()
		{
		}

		private void AddMoney()
		{
		}

		public void SetRainState(int istate)
		{
		}

		private void ToggleDamage()
		{
		}

		private void ToggleDirt()
		{
		}

		private void UpdateDamageAndDirtText()
		{
		}

		private void GetPlaces()
		{
		}

		private void GotoPlaces(GameObject target)
		{
		}
	}
}
