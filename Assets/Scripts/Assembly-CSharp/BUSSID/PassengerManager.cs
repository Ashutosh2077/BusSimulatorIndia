using System.Collections.Generic;
using GameplayEvent;
using UIEvent;
using UnityEngine;

namespace BUSSID
{
	public class PassengerManager : MonoBehaviour
	{
		public static PassengerManager Instance;

		public GameObject passengerPrefab;

		public int passengersPerPointCount;

		public float farePerKMCareer;

		public int limitPassengerDroppedOnLastScene;

		public List<PassengerInfo> passengerPickedUp;

		public List<PassengerInfo> passengerDroppedOff;

		public List<TripRecord> completedTrips;

		private List<PassengerSpawnerInfo> passengerOnEachCities;

		public List<PassengerInfo> lastPassengerSpawnerInfo;

		private string KEY_PS_PICKEDUP;

		private string KEY_COMPLETED_TRIP;

		private string KEY_PASSENGERS_DATA_GENERATED;

		private string KEY_PASSENGERS_INFO;

		private void Awake()
		{
		}

		private void OnSceneLoaded(SceneLoaded e)
		{
		}

		private void OnEnterGarage(EnterGarage e)
		{
		}

		private void WorldMapPathRecalculated(WorldMapPathRecalculated e)
		{
		}

		public void GeneratePassengerDataForCurrentRoute()
		{
		}

		public PassengerSpawnerInfo getPassengerOnCity(string _city)
		{
			return null;
		}

		public int getTotalPassengerValueInBus()
		{
			return 0;
		}

		public int getPassengerVisibleInBus()
		{
			return 0;
		}

		public GameObject SpawnRandomPassenger(Vector3 pos, Quaternion rot)
		{
			return null;
		}

		public GameObject SpawnRandomPassenger(Vector3 pos, Quaternion rot, List<string> _passengerList)
		{
			return null;
		}

		public GameObject SpawnPassenger(string id)
		{
			return null;
		}

		public void Reset()
		{
		}

		public void SaveData()
		{
		}

		public void LoadData()
		{
		}

		public void ResetData()
		{
		}
	}
}
