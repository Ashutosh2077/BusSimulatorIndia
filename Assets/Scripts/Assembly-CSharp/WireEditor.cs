using System;
using System.Collections.Generic;
using UnityEngine;

public class WireEditor : EditableShape
{
	[Serializable]
	public class WireSpline : Spline
	{
		public ElectricWireSettings settings;

		public List<GameObject> gameObjects;

		public List<Vector3> attachPoints;

		public void CleanupGameObjects()
		{
		}

		public void AddGameObject(GameObject go)
		{
		}
	}

	public ElectricWireSettings defaultWire;

	[HideInInspector]
	public GameObject meshesRoot;

	[ReadOnly]
	public List<WireSpline> splines;

	private List<WireSpline> attachSplines;

	public override Spline CreateSpline()
	{
		return null;
	}

	public override IEnumerable<Spline> GetSplines()
	{
		return null;
	}

	public override void ClearSplines()
	{
	}

	public override void RemoveDeletedSplines()
	{
	}

	public ElectricWireSettings GetSplineWireSettings(Spline ds)
	{
		return null;
	}

	public override void OnSplineRebuild(Spline ds)
	{
	}

	private void CollectAttachPoints()
	{
	}

	private Vector3 FindNearestAttachPoint(Vector3 pos)
	{
		return default(Vector3);
	}

	public override void ForceRebuild()
	{
	}

	public override void BeforePlacePointsOnGroundCall()
	{
	}

	public override void AfterPlacePointsOnGroundCall()
	{
	}
}
