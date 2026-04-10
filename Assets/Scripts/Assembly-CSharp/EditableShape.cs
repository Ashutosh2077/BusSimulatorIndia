using System;
using System.Collections.Generic;
using UnityEngine;

public class EditableShape : MonoBehaviour
{
	[Serializable]
	public class Spline
	{
		public int id;

		public Vector3[] points;

		public bool smooth;

		[NonSerialized]
		public bool deleted;
	}

	public bool pointsFollowGround;

	public float cullChildrenDistance;

	public virtual void ForceRebuild()
	{
	}

	public virtual void OnSplineBeginRebuild()
	{
	}

	public virtual void OnSplineRebuild(Spline ds)
	{
	}

	public virtual void BeforePlacePointsOnGroundCall()
	{
	}

	public virtual void AfterPlacePointsOnGroundCall()
	{
	}

	public virtual Spline CreateSpline()
	{
		return null;
	}

	public virtual IEnumerable<Spline> GetSplines()
	{
		return null;
	}

	public virtual void ClearSplines()
	{
	}

	public int GetMaxSplineId()
	{
		return 0;
	}

	public void LoadFromRoadsData()
	{
	}

	public virtual void RemoveDeletedSplines()
	{
	}

	public virtual GameObject CheckMeshesRootCreated(GameObject meshesRoot)
	{
		return null;
	}

	protected GameObject CreateMeshesRoot(GameObject oldMeshesRoot)
	{
		return null;
	}

	protected GameObject ClonePrefab(GameObject prefab)
	{
		return null;
	}
}
