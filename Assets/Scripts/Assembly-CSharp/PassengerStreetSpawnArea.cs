using System.Collections.Generic;
using BUSSID;
using GameplayEvent;
using UnityEngine;

public class PassengerStreetSpawnArea : MonoBehaviour
{
	[SerializeField]
	private List<ExitGatePortalProxy> enabledForGates;

	[SerializeField]
	[ReadOnly]
	private List<string> gatesName;

	private PassengerPoint pp;

	private PassengerGroupData passengerGroupData;

	private GameObject iconPrefab;

	private bool isSceneReady;

	private bool isAlreadySpawn;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Init(ExitGatePortalProxy[] exitGates, PassengerPoint _pp, PassengerGroupData _passengerGroupData, GameObject _iconPrefab)
	{
	}

	private void OnRefreshGPS(OnRefreshGPS e)
	{
	}

	private void OnSceneLoaded(SceneLoaded e)
	{
	}
}
