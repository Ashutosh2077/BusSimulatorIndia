using System.Collections.Generic;
using BUSSID;
using UnityEngine;

public class PassengerSpawnerStreet : MonoBehaviour
{
	[SerializeField]
	private PassengerGroupData passengerGroupData;

	[SerializeField]
	private GameObject iconPrefab;

	private List<PassengerPoint> pPoint;

	private ExitGatePortalProxy[] exitGates;

	private bool isBusNear;

	private bool isOnBoarding;

	private PassengerVehicle playerVehicle => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnTargetEnteredRange(PassengerPoint self, GameObject other)
	{
	}

	private void OnTargetStayedRange(PassengerPoint self, GameObject other)
	{
	}

	private void OnTargetExitedRange(PassengerPoint self, GameObject other)
	{
	}
}
