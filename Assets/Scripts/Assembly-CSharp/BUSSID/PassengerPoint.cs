using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameplayEvent;
using UnityEngine;

namespace BUSSID
{
	public class PassengerPoint : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSpawnStreetPassengers_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PassengerPoint _003C_003E4__this;

			public PassengerGroupData passengerGroupData;

			public GameObject iconPrefab;

			public int maxSpawn;

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
			public _003CSpawnStreetPassengers_003Ed__21(int _003C_003E1__state)
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

		public List<PassengerBehavior> passengers;

		public List<PassengerBehavior> passengerCanEnterVehicle;

		private PassengerManager psManager;

		private int totalPassengerToSpawn;

		private List<PassengerInfo> psData;

		private const int maxStreetModePassengerLimit = 60;

		private bool forStreet;

		protected static Database _database => null;

		public event Action<PassengerPoint, GameObject> OnTargetEnteredRange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<PassengerPoint, GameObject> OnTargetStayedRange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<PassengerPoint, GameObject> OnTargetExitedRange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnSettingChanged(SettingChanged e)
		{
		}

		public void TogglePassengerVisibility()
		{
		}

		public static PassengerPoint Get(GameObject owner)
		{
			return null;
		}

		public void SpawnPassengers(PassengerGroupData passengerGroupData = null, List<PassengerInfo> ps = null, GameObject iconPrefab = null, int maxSpawn = 200)
		{
		}

		private bool SpawnPassenger(PassengerGroupData passengerGroupData = null, List<PassengerInfo> _ps = null, GameObject iconPrefab = null)
		{
			return false;
		}

		public void StartBoarding()
		{
		}

		public void OnPassengerBoarded(PassengerBehavior _passenger)
		{
		}

		public void ForceBoardingComplete()
		{
		}

		public void OnPassengerGetOffVehicle(PassengerBehavior passenger)
		{
		}

		public int MaxStreetModePassengerLimit()
		{
			return 0;
		}

		[IteratorStateMachine(typeof(_003CSpawnStreetPassengers_003Ed__21))]
		public IEnumerator SpawnStreetPassengers(PassengerGroupData passengerGroupData = null, GameObject iconPrefab = null, int maxSpawn = 200)
		{
			return null;
		}

		private bool IsBusInRange()
		{
			return false;
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}
	}
}
