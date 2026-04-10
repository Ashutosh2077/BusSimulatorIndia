using System.Collections.Generic;
using UnityEngine;

namespace Fusion.Editor
{
	public static class BoundsTools
	{
		public enum BoundsType
		{
			Both = 0,
			MeshRenderer = 1,
			Collider = 2,
			Manual = 3
		}

		private static readonly List<MeshFilter> meshFilters;

		private static readonly List<Renderer> meshRenderers;

		private static readonly List<Collider> colliders;

		private static readonly List<Collider> validColliders;

		private static readonly List<SpriteRenderer> spriteRenderers;

		private static readonly List<Collider2D> colliders2D;

		private static readonly List<Collider2D> validColliders2D;

		public static Bounds CollectMyBounds(this GameObject go, BoundsType factorIn, out int numOfBoundsFound, bool includeChildren = true, bool includeInactive = false)
		{
			numOfBoundsFound = default(int);
			return default(Bounds);
		}

		public static Bounds CollectMyBounds(GameObject go, BoundsType factorIn, bool includeChildren = true)
		{
			return default(Bounds);
		}
	}
}
