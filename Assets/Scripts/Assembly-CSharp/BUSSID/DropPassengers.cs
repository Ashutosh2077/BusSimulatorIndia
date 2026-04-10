using System;
using GameplayEvent;
using UnityEngine;

namespace BUSSID
{
	public static class DropPassengers
	{
		private static PassengerPoint dropPoint;

		private static Action onDropComplete;

		public static void BeginDropPassengers(GameObject point, Action onComplete)
		{
		}

		private static void FadeInAndDropPassengers()
		{
		}

		private static void OnDropPassengerFadeoutComplete()
		{
		}

		private static void ForceDropComplete(ForceDropComplete e)
		{
		}

		private static void DropComplete(DropComplete e)
		{
		}

		private static void OnAllPassengersGetOff()
		{
		}
	}
}
