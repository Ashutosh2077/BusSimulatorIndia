using System.Collections.Generic;
using Fusion;
using UnityEngine;
using UnityEngine.UI;

public class FusionGraph : FusionGraphBase
{
	public enum Layouts
	{
		Auto = 0,
		FullAuto = 1,
		FullNoOverlap = 2,
		CenteredAuto = 3,
		CenteredNoGraph = 4,
		CenteredNoOverlap = 5,
		CompactAuto = 6,
		CompactNoGraph = 7
	}

	public enum ShowGraphOptions
	{
		Never = 0,
		OverlayOnly = 1,
		Always = 2
	}

	private enum ShaderType
	{
		None = 0,
		Overlay = 1,
		GameObject = 2
	}

	private const int GRPH_TOP_PAD = 36;

	private const int GRPH_BTM_PAD = 36;

	private const int HIDE_XTRAS_WDTH = 200;

	private const int INTERMITTENT_DATA_ARRAYSIZE = 128;

	private const int EXPAND_GRPH_THRESH = 112;

	private const int COMPACT_THRESH = 52;

	[SerializeField]
	[HideInInspector]
	public float Height;

	[InlineHelp]
	[SerializeField]
	[Header("Graph Layout")]
	private Layouts _layout;

	[InlineHelp]
	[SerializeField]
	private ShowGraphOptions _showGraph;

	[InlineHelp]
	public float Padding;

	[InlineHelp]
	[SerializeField]
	private bool _alwaysExpandGraph;

	[InlineHelp]
	[SerializeField]
	private bool _showUITargets;

	[DrawIf("_showUITargets", Hide = true)]
	public Image GraphImg;

	[DrawIf("_showUITargets", Hide = true)]
	public Text LabelMin;

	[DrawIf("_showUITargets", Hide = true)]
	public Text LabelMax;

	[DrawIf("_showUITargets", Hide = true)]
	public Text LabelAvg;

	[DrawIf("_showUITargets", Hide = true)]
	public Text LabelLast;

	[DrawIf("_showUITargets", Hide = true)]
	public Text LabelPer;

	[DrawIf("_showUITargets", Hide = true)]
	public Dropdown _viewDropdown;

	[DrawIf("_showUITargets", Hide = true)]
	public Button _avgBttn;

	private float _min;

	private float _max;

	private float[] _values;

	private float[] _intensity;

	private float[] _histogram;

	private List<int> DropdownLookup;

	[InlineHelp]
	private FusionGraphVisualization _graphVisualization;

	private ShaderType _currentShader;

	private (int tick, float value)[] _cachedValues;

	private double _lastCachedTickTime;

	private int _lastCachedTick;

	private int _histoHighestUsedBucketIndex;

	private int _histoAvgSampleCount;

	private double _histoStepInverse;

	private double _histoAvg;

	private static Shader Shader => null;

	public Layouts Layout
	{
		get
		{
			return default(Layouts);
		}
		set
		{
		}
	}

	public ShowGraphOptions ShowGraph
	{
		get
		{
			return default(ShowGraphOptions);
		}
		set
		{
		}
	}

	public bool AlwaysExpandGraph
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public FusionGraphVisualization GraphVisualization
	{
		set
		{
		}
	}

	protected override bool TryConnect()
	{
		return false;
	}

	private void Reset()
	{
	}

	public void Clear()
	{
	}

	public override void Initialize()
	{
	}

	public void OnDropdownChanged(int value)
	{
	}

	[BehaviourButtonAction("ResetShader", null, null)]
	private void ResetShaderButton()
	{
	}

	private void ResetGraphShader()
	{
	}

	public override void CyclePer()
	{
	}

	private void SetPerText()
	{
	}

	public override void Refresh()
	{
	}

	private void UpdateContinuousTick(ref IStatsBuffer data)
	{
	}

	private void UpdateIntermittentTick(ref IStatsBuffer data)
	{
	}

	private void UpdateIntermittentTime(ref IStatsBuffer data)
	{
	}

	private void ApplyScaling(ref float min, ref float max)
	{
	}

	private void UpdateUiText(float min, float max, float avg, float last)
	{
	}

	private float GetIntermittentAverageInfo(ref IStatsBuffer data, float sum)
	{
		return 0f;
	}

	private void UpdateTickValueHistogram(ref IStatsBuffer data)
	{
	}

	public static FusionGraph Create(FusionStats iFusionStats, Simulation.Statistics.StatSourceTypes statSourceType, int statId, RectTransform parentRT)
	{
		return null;
	}

	public void Generate(Simulation.Statistics.StatSourceTypes type, int statId, RectTransform root)
	{
	}

	[BehaviourButtonAction("Update Layout", null, null)]
	public override void CalculateLayout()
	{
	}
}
