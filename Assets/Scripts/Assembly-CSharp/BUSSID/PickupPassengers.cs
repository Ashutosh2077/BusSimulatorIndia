using System;
using GameplayEvent;
using UnityEngine;

namespace BUSSID
{
	public static class PickupPassengers
	{
		private static PassengerPoint pickPoint;

		private static Action onPickupComplete;

		public static void BeginPickupPassengers(GameObject point, Action onComplete, bool skipStartFadeIn = false)
		{
		}

		private static void StartPickPassengers()
		{
		}

		private static void OnPickPassenngersFadeoutComplete()
		{
		}

		private static void ForceBoardingComplete(ForceBoardingComplete e)
		{
		}

		private static void BoardingComplete(BoardingComplete e)
		{
		}

		private static void OnFadeInAfterBoarding()
		{
		}
	}
}
