using UnityEngine;

namespace Fusion
{
	internal static class FusionRuntimeCheck
	{
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void RuntimeCheck()
		{
		}
	}
}
