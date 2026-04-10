using System.Collections.Generic;
using UnityEngine;

public class SceneDensityInfo : MonoBehaviour
{
	public struct IXZ
	{
		public int ix;

		public int iz;

		public IXZ(int _ix, int _iz)
		{
			ix = 0;
			iz = 0;
		}

		public Vector3 AsVector3()
		{
			return default(Vector3);
		}
	}

	public struct ExpectedDrawCall
	{
		public Material mat;

		public MeshRenderer meshRenderer;

		public ExpectedDrawCall(Material _mat, MeshRenderer _meshRenderer)
		{
			mat = null;
			meshRenderer = null;
		}
	}

	public class Chunk
	{
		public Bounds bounds;

		public Bounds renderersBounds;

		public List<MeshRenderer> renderers;

		public int triangles;

		public HashSet<Material> materials;

		public HashSet<ExpectedDrawCall> expectedDrawCalls;
	}

	public int chunkSize;

	public int drawCallsLimit;

	public int trianglesLimit;

	private List<Chunk> chunks;

	public Gradient densityGradientCalls;

	public Gradient densityGradientTriangles;

	public SceneInfo.SceneInfoResult sceneShaders;

	private float maxDrawCallsLimit => 0f;

	private float maxTrianglesLimit => 0f;

	private IXZ Vector3ToIXZ(Vector3 pos)
	{
		return default(IXZ);
	}

	public void GetInfo()
	{
	}

	public void GetMaterialsInfo()
	{
	}

	public void Clear()
	{
	}

	private void RefreshViewport()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void DrawChart(Vector3 pos, float delta)
	{
	}
}
