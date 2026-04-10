using System.Collections.Generic;
using GameplayEvent;
using UnityEngine;

namespace BUSSID
{
	[AddComponentMenu(null)]
	public class PassengerBehavior : MonoBehaviour
	{
		public enum State
		{
			Idle = 0,
			Queue = 1,
			Walking = 2,
			Waiting = 3,
			Boarding = 4,
			OffBoarding = 5,
			Sitting = 6,
			None = 7
		}

		public enum Phase
		{
			PickingUp = 0,
			DroppedOff = 1
		}

		public State passengerState;

		public Phase passengerPhase;

		private PassengerManager psManager;

		public GameObject myPassengerSeatsObj;

		public PassengerInfo myInfo;

		public PassengerVehicle playerVehicle;

		public PassengerPoint ownerPoint;

		public Vector3 moveTarget;

		private float moveSpeed;

		private GameObject targetStairs;

		private Rigidbody rbody;

		private GameObject icon;

		private CharacterVisual _visual;

		private List<PassengerBehavior> passengersOnTrigger;

		private PassengerBehavior passengersInFront;

		private bool waving;

		private float distancePassengerToPickup;

		private float rbMassDefault;

		[HideInInspector]
		public bool alreadyBoarding;

		private float timer;

		private float randIdleEverySec;

		private float timerQueue;

		private float fov;

		public CharacterVisual visual => null;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnSceneUnload(SceneUnload e)
		{
		}

		private void OnDestroy()
		{
		}

		public void Init(State _state = State.Idle)
		{
		}

		public void SetHiddenForPerformance(bool _isHidden = true)
		{
		}

		public void UpdateVisualHiddenForPerformace()
		{
		}

		public void StartBoarding()
		{
		}

		private void SetupPassengerInfo()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void SetState(State _state)
		{
		}

		private void RandomIdleAnim()
		{
		}

		private void Idling()
		{
		}

		private void Queueing()
		{
		}

		private void Walking()
		{
		}

		public void DroppedCompleted()
		{
		}

		public void BoardingCompleted()
		{
		}

		public void SitInsideVehicle()
		{
		}

		public void SetSitPosition()
		{
		}

		private void GettingOff()
		{
		}

		private void Sitting()
		{
		}

		private void OnAnimationComplete(string _animationName)
		{
		}

		private bool IsBusNearAndCanEnter()
		{
			return false;
		}

		private bool IsBusInRange(float distance = 0f)
		{
			return false;
		}

		private void DecideWhichDoor()
		{
		}

		private void CheckPassengerCollision()
		{
		}

		public void ResetState()
		{
		}

		private void DestroyOnFalling()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void ToggleCollider(bool isEnable)
		{
		}

		private void OnDisable()
		{
		}
	}
}
