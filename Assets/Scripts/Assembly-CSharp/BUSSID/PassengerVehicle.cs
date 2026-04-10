using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BusSimulator.CustomEVP;
using BusSimulator.Vehicle;
using EVP;
using GameplayEvent;
using UnityEngine;

namespace BUSSID
{
	public class PassengerVehicle : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CPassengerGetOutOffVehicle_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PassengerVehicle _003C_003E4__this;

			public PassengerPoint dropPoint;

			public Action onComplete;

			private int _003Ccnt_003E5__2;

			private int _003Ci_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CPassengerGetOutOffVehicle_003Ed__36(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private static PassengerVehicle instance;

		public GameObject passengerSeatsObj;

		private GameObject playerVehicleObj;

		private List<Seat> allSeats;

		private BUSSIDVehicleVisualEffects playerVehicleVisual;

		private MachineController playerVehicleMachine;

		private VehicleController playerVehicleController;

		private List<PassengerAIMovement> passengersAI;

		private List<PassengerInfo> psDroppedOnCurrentCity;

		private bool readyToPickUpPassenger;

		private PassengerManager psManager;

		private int doorID;

		public static PassengerVehicle Instance => null;

		private void Awake()
		{
		}

		private void Init()
		{
		}

		public void SetReadyToPickPassengers(bool ready)
		{
		}

		public List<KeyValuePair<GameObject, GameObject>> GetDoorsStairs()
		{
			return null;
		}

		public void OnSettingChanged(SettingChanged e)
		{
		}

		public bool IsReadyToPickUpPassenger()
		{
			return false;
		}

		public bool IsDoorOpened()
		{
			return false;
		}

		public bool IsMoving()
		{
			return false;
		}

		public void TogglePassengerVisibility(bool _resetupPassenger = true)
		{
		}

		public Transform getPassengerSeatTransform()
		{
			return null;
		}

		public int getTotalSeat()
		{
			return 0;
		}

		public int getTotalAvailableSeat()
		{
			return 0;
		}

		public Seat getAvailableSeat()
		{
			return default(Seat);
		}

		public Seat getSeatByID(int _id)
		{
			return default(Seat);
		}

		public void ClearAllPassengerObjectOnSeats()
		{
		}

		private void ResetAllSeats()
		{
		}

		public void ResetupAllPassengerInside()
		{
		}

		public void ToggleVehicleDoor(bool _open = false)
		{
		}

		private void OnDestroy()
		{
		}

		public void OnPassengerBoarded(PassengerBehavior passenger)
		{
		}

		private void PreparePassengerDropOnCurrentCity()
		{
		}

		public void BeginPassengerGetOutOffVehicle(PassengerPoint dropPoint, Action onComplete)
		{
		}

		[IteratorStateMachine(typeof(_003CPassengerGetOutOffVehicle_003Ed__36))]
		private IEnumerator PassengerGetOutOffVehicle(PassengerPoint dropPoint, Action onComplete)
		{
			return null;
		}

		public void DropAllPassengerDirectly(PassengerPoint dropPoint, Action onComplete, bool _spawnAsHidden = false)
		{
		}

		private PassengerBehavior SpawnPassenger(PassengerPoint dropPoint, PassengerInfo ps, bool isDropInstantly)
		{
			return null;
		}

		private void MovePassengerToLandmark()
		{
		}

		private void OnPassengerReachedTarget(PassengerAIMovement passenger)
		{
		}

		private void OnBoardingComplete(BoardingComplete evt)
		{
		}

		private void OnForceBoardingComplete(ForceBoardingComplete evt)
		{
		}
	}
}
