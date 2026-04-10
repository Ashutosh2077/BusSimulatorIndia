using Fusion;
using UnityEngine;
using UnityEngine.UI;

public class FusionStatsMeterBar : FusionGraphBase
{
	public float HoldPeakTime;

	public float DecayTime;

	[InlineHelp]
	public int MeterMax;

	[InlineHelp]
	[SerializeField]
	private bool _showUITargets;

	[DrawIf("_showUITargets", Hide = true)]
	public Text ValueLabel;

	[DrawIf("_showUITargets", Hide = true)]
	public Image Bar;

	private double _currentDisplayValue;

	private double _currentBarValue;

	private Color CurrentColor;

	private double _lastImportedSampleTickTime;

	private double _max;

	private double _total;

	private float _lastPeakSetTime;

	protected override Color BackColor => default(Color);

	public override void Initialize()
	{
	}

	public override void Refresh()
	{
	}

	public void LateUpdate()
	{
	}

	public void SetValue(double rawvalue)
	{
	}

	private void SetBar(double value)
	{
	}

	public override void CalculateLayout()
	{
	}

	public static FusionStatsMeterBar Create(RectTransform parent, FusionStats fusionStats, Simulation.Statistics.StatSourceTypes statSourceType, int statId, float warnThreshold, float alertThreshold)
	{
		return null;
	}

	public void GenerateMeter()
	{
	}
}
