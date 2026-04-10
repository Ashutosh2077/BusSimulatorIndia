using Fusion;
using Fusion.StatsInternal;
using UnityEngine;
using UnityEngine.UI;

public class FusionStatsObjectIds : Fusion.Behaviour, IFusionStatsView
{
	protected const int PAD = 10;

	protected const int MARGIN = 6;

	[SerializeField]
	[HideInInspector]
	private Text _inputValueText;

	[SerializeField]
	[HideInInspector]
	private Text _stateValueText;

	[SerializeField]
	[HideInInspector]
	private Text _objectIdLabel;

	[SerializeField]
	[HideInInspector]
	private Image _stateAuthBackImage;

	[SerializeField]
	[HideInInspector]
	private Image _inputAuthBackImage;

	private FusionStats _fusionStats;

	private static Color _noneAuthColor;

	private static Color _inputAuthColor;

	private static Color _stateAuthColor;

	private const float LABEL_DIVIDING_POINT = 0.7f;

	private const float TEXT_PAD = 4f;

	private const float TEXT_PAD_HORIZ = 6f;

	private const int MAX_TAG_FONT_SIZE = 18;

	private bool _previousHasInputAuth;

	private bool _previousHasStateAuth;

	private int _previousInputAuthValue;

	private int _previousStateAuthValue;

	private uint _previousObjectIdValue;

	bool IFusionStatsView.isActiveAndEnabled => false;

	Transform IFusionStatsView.transform => null;

	private void Awake()
	{
	}

	void IFusionStatsView.Initialize()
	{
	}

	public static RectTransform Create(RectTransform parent, FusionStats fusionStats)
	{
		return null;
	}

	public void Generate()
	{
	}

	private RectTransform AddAuthorityPanel(RectTransform parent, string label, ref Text valueText, ref Image backImage)
	{
		return null;
	}

	void IFusionStatsView.CalculateLayout()
	{
	}

	void IFusionStatsView.Refresh()
	{
	}
}
