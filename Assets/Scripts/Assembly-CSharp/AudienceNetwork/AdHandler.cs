using System;
using System.Collections.Generic;
using UnityEngine;

namespace AudienceNetwork
{
	public class AdHandler : MonoBehaviour
	{
		private static readonly Queue<Action> executeOnMainThreadQueue;

		public void ExecuteOnMainThread(Action action)
		{
		}

		private void Update()
		{
		}

		public void RemoveFromParent()
		{
		}
	}
}
