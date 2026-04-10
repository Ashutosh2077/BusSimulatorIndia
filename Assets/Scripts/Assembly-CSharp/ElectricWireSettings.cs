using System;
using UnityEngine;

[CreateAssetMenu(fileName = "ElectricWireSettings", menuName = "BUSSID/ElectricWireSettings")]
public class ElectricWireSettings : ScriptableObject
{
	public enum WireType
	{
		Double = 0,
		Left = 1,
		Right = 2
	}

	[Serializable]
	public class WireSettings
	{
		public WireType wireType;

		public GameObject wirePrefab;

		public float wireHeight;

		public float wireSpace;

		public bool connectToNearestPole;

		public bool isAttachPoint;

		public bool ConnectToNearestPoleNotNull => false;
	}

	public GameObject polePrefab;

	public WireSettings wireSet1;

	public WireSettings wireSet2;

	public bool connectToNearestPole => false;
}
