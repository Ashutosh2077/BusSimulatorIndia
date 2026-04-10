using System;
using System.Collections.Generic;
using UnityEngine;

public class FenceEditor : EditableShape
{
	[Serializable]
	public class FenceSpline : Spline
	{
		public GameObject prefab;

		public bool firstNode;

		public bool lastNode;

		public List<GameObject> gameObjects;

		public void CleanupGameObjects()
		{
		}

		public void AddGameObject(GameObject go)
		{
		}
	}

	private class SplineSampler
	{
		public class Point
		{
			public Vector3 pos;

			public Vector3 dir;

			public float len;
		}

		public List<Point> points;

		public float fullLen;

		public void Clear()
		{
		}

		public void Add(Vector3 pos)
		{
		}

		public void Recalculate()
		{
		}

		public Vector3 Sample(float distance)
		{
			return default(Vector3);
		}

		public SplineSampler Clone()
		{
			return null;
		}

		public void MakeFlat()
		{
		}
	}

	public GameObject defaultFencePrefab;

	[HideInInspector]
	public GameObject meshesRoot;

	[ReadOnly]
	public List<FenceSpline> splines;

	private SplineSampler splineSampler;

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

	public override void OnSplineBeginRebuild()
	{
	}

	public GameObject GetSplinePrefab(Spline ds)
	{
		return null;
	}

	public override void OnSplineRebuild(Spline ds)
	{
	}

	private Bounds GetWorldBounds(GameObject go)
	{
		return default(Bounds);
	}

	private void PlaceSplinePrefabsSmooth(List<Vector3> result, FenceSpline s, float prefabLen)
	{
	}

	private void PlaceSplinePrefabsLinear(List<Vector3> result, FenceSpline s, float prefabLen)
	{
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
