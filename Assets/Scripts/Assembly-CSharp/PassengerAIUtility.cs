using UnityEngine;

public static class PassengerAIUtility
{
	public struct Box
	{
		public Vector3 localFrontTopLeft { get; private set; }

		public Vector3 localFrontTopRight { get; private set; }

		public Vector3 localFrontBottomLeft { get; private set; }

		public Vector3 localFrontBottomRight { get; private set; }

		public Vector3 localBackTopLeft => default(Vector3);

		public Vector3 localBackTopRight => default(Vector3);

		public Vector3 localBackBottomLeft => default(Vector3);

		public Vector3 localBackBottomRight => default(Vector3);

		public Vector3 frontTopLeft => default(Vector3);

		public Vector3 frontTopRight => default(Vector3);

		public Vector3 frontBottomLeft => default(Vector3);

		public Vector3 frontBottomRight => default(Vector3);

		public Vector3 backTopLeft => default(Vector3);

		public Vector3 backTopRight => default(Vector3);

		public Vector3 backBottomLeft => default(Vector3);

		public Vector3 backBottomRight => default(Vector3);

		public Vector3 origin { get; private set; }

		public Box(Vector3 origin, Vector3 halfExtents, Quaternion orientation)
		{
			localFrontTopLeft = default(Vector3);
			localFrontTopRight = default(Vector3);
			localFrontBottomLeft = default(Vector3);
			localFrontBottomRight = default(Vector3);
			this.origin = default(Vector3);
		}

		public Box(Vector3 origin, Vector3 halfExtents)
		{
			localFrontTopLeft = default(Vector3);
			localFrontTopRight = default(Vector3);
			localFrontBottomLeft = default(Vector3);
			localFrontBottomRight = default(Vector3);
			this.origin = default(Vector3);
		}

		public void Rotate(Quaternion orientation)
		{
		}
	}

	public static Vector3 OrientationToVector(float orientation)
	{
		return default(Vector3);
	}

	public static float VectorToOrientation(Vector3 direction)
	{
		return 0f;
	}

	public static void DebugCross(Vector3 position, float size = 0.5f, Color color = default(Color), float duration = 0f, bool depthTest = true)
	{
	}

	public static Vector3 DirOnPlane(Vector3 vector, Vector3 planeNormal)
	{
		return default(Vector3);
	}

	public static Vector3 ToPlanar(this Vector3 v)
	{
		return default(Vector3);
	}

	public static void DrawBoxCast(Vector3 origin, Vector3 halfExtents, Quaternion orientation, Vector3 direction, float distance, Color color)
	{
	}

	public static void DrawBox(Vector3 origin, Vector3 halfExtents, Quaternion orientation, Color color)
	{
	}

	private static void DrawBox(Box box, Color color)
	{
	}

	private static Vector3 CastCenterOnCollision(Vector3 origin, Vector3 direction, float hitInfoDistance)
	{
		return default(Vector3);
	}

	private static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Quaternion rotation)
	{
		return default(Vector3);
	}
}
