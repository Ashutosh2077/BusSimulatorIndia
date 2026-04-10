using System;
using UnityEngine;

[Serializable]
public class PassengerAIPath
{
	protected float maxDist;

	public Vector3[] points { get; private set; }

	public float[] distances { get; private set; }

	public Vector3 this[int i]
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public int Length => 0;

	public Vector3 EndNode => default(Vector3);

	public PassengerAIPath(Vector3[] points)
	{
	}

	public void CalcDistances()
	{
	}

	public void Draw()
	{
	}

	public float GetParam(Vector3 position)
	{
		return 0f;
	}

	public int GetClosestSegment(Vector3 position)
	{
		return 0;
	}

	public Vector3 GetPosition(float param, bool pathLoop = false)
	{
		return default(Vector3);
	}

	private float DistToSegment(Vector3 p, Vector3 v, Vector3 w)
	{
		return 0f;
	}

	private float GetParamForSegment(Vector3 p, Vector3 v, Vector3 w)
	{
		return 0f;
	}
}
