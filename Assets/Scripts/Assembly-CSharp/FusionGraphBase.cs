using System;
using Fusion;
using Fusion.StatsInternal;
using UnityEngine;
using UnityEngine.UI;

[ScriptHelp(BackColor = EditorHeaderBackColor.Olive)]
public abstract class FusionGraphBase : Fusion.Behaviour, IFusionStatsView
{
	public enum StatsPer
	{
		Default = 0,
		Individual = 1,
		Tick = 2,
		Second = 4
	}

	protected const int PAD = 10;

	protected const int MRGN = 6;

	protected const int MAX_FONT_SIZE_WITH_GRAPH = 24;

	[SerializeField]
	[HideInInspector]
	protected Text LabelTitle;

	[SerializeField]
	[HideInInspector]
	protected Image BackImage;

	[InlineHelp]
	[SerializeField]
	protected Simulation.Statistics.StatSourceTypes _statSourceType;

	[InlineHelp]
	[SerializeField]
	[CastEnum("CastToStatType")]
	protected int _statId;

	[InlineHelp]
	public StatsPer StatsPerDefault;

	[InlineHelp]
	public float WarnThreshold;

	[InlineHelp]
	public float ErrorThreshold;

	protected IStatsBuffer _statsBuffer;

	protected bool _isOverlay;

	protected FusionStats _fusionStats;

	protected bool _layoutDirty;

	protected Simulation.Statistics.StatsPer CurrentPer;

	public Simulation.Statistics.StatSourceInfo StatSourceInfo;

	[SerializeField]
	[HideInInspector]
	private Simulation.Statistics.StatSourceTypes _prevStatSourceType;

	[SerializeField]
	[HideInInspector]
	private int _prevStatId;

	public Simulation.Statistics.StatSourceTypes StateSourceType
	{
		get
		{
			return default(Simulation.Statistics.StatSourceTypes);
		}
		set
		{
		}
	}

	public int StatId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public IStatsBuffer StatsBuffer => null;

	public bool IsOverlay
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected virtual Color BackColor => default(Color);

	protected Type CastToStatType => null;

	bool IFusionStatsView.isActiveAndEnabled => false;

	Transform IFusionStatsView.transform => null;

	protected FusionStats LocateParentFusionStats()
	{
		return null;
	}

	public virtual void Initialize()
	{
	}

	public virtual void CyclePer()
	{
	}

	public abstract void CalculateLayout();

	public abstract void Refresh();

	protected virtual bool TryConnect()
	{
		return false;
	}

	protected void ApplyTitleText()
	{
	}

	protected void CheckIfValidIncurrentMode(NetworkRunner runner)
	{
	}
}
