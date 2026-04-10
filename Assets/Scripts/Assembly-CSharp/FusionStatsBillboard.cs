using Fusion;
using UnityEngine;

[ScriptHelp(BackColor = EditorHeaderBackColor.Olive)]
[ExecuteAlways]
public class FusionStatsBillboard : Fusion.Behaviour
{
	[InlineHelp]
	public Camera Camera;

	private static float _lastCameraFindTime;

	private static Camera _currentCam;

	private FusionStats _fusionStats;

	private Camera MainCamera
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void LateUpdate()
	{
	}

	public void UpdateLookAt()
	{
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}
}
