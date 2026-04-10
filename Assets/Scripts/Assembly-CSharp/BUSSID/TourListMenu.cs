using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BusSimulator.Menu;
using BusSimulator.Modules.WorldMap;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.UI;

namespace BUSSID
{
	public class TourListMenu : MenuController
	{
		public class DataResultListCountDown
		{
			public string timeLeft;

			public string targetDate;
		}

		public class TourTimeTargetFormat
		{
			public string dayName;

			public DateTime date;

			public string gmt;
		}

		[CompilerGenerated]
		private sealed class _003CUpdateLayoutGroup_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TourListMenu _003C_003E4__this;

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
			public _003CUpdateLayoutGroup_003Ed__33(int _003C_003E1__state)
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

		public Text countDownTxt;

		public Transform listContainer;

		public GameObject objectList;

		public GameObject objectListDownload;

		public GameObject detailPanel;

		public GameObject detailContainer;

		public Text tourNameTxt;

		public Text departureTxt;

		public Transform destinationContainer;

		public GameObject destinationPrefab;

		public Text fareTxt;

		public Text bonusTxt;

		public Text totalFareTxt;

		private Database database;

		private WMPoint firstTourPoint;

		private ObscuredInt timeleft;

		private void Start()
		{
		}

		private void FetchCountDownFromLocalUserTitleData()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnApplicationPause(bool paused)
		{
		}

		private void UpdateCountDownText()
		{
		}

		public void ResetDataTourList()
		{
		}

		private void LoadLastDeparture()
		{
		}

		private void ClearContent()
		{
		}

		private List<Location> TourDataToLocationsList(TourData tourData)
		{
			return null;
		}

		private void FillCurrentRoute(TourData tourData)
		{
		}

		private void FillContent()
		{
		}

		private void GenerateDefaultTourList()
		{
		}

		private void GenerateTourList()
		{
		}

		private string GetTimeBeforeResetTourList()
		{
			return null;
		}

		private DateTime nextDay(string _day)
		{
			return default(DateTime);
		}

		public void ShowDetail(int _id)
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateLayoutGroup_003Ed__33))]
		private IEnumerator UpdateLayoutGroup()
		{
			return null;
		}

		public void CancelDetail()
		{
		}

		private WMPoint GetWMPoint(string _id)
		{
			return null;
		}

		public override void Show()
		{
		}

		public override void Hide()
		{
		}

		private void Update()
		{
		}
	}
}
