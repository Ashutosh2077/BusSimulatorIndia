using System;
using System.Collections.Generic;
using UnityEngine;

public class SceneInfo
{
	[Serializable]
	public class SceneInfoResult
	{
		[NonReorderable]
		public List<GameObject> lessZeroScaledObjects;

		[NonReorderable]
		public List<ShaderGroup> usedShaders;
	}

	[Serializable]
	public class ShaderGroup
	{
		public string name;

		public Shader shader;

		[NonReorderable]
		public List<MaterialGroup> materials;
	}

	[Serializable]
	public class MaterialGroup
	{
		public Material material;

		[NonReorderable]
		public List<GameObject> gameObjects;
	}

	public static SceneInfoResult GetInfo()
	{
		return null;
	}
}
