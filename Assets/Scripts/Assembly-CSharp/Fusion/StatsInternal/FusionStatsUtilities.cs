using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Fusion.StatsInternal
{
	public static class FusionStatsUtilities
	{
		public const int PAD = 10;

		public const int MARGIN = 6;

		public const int FONT_SIZE = 12;

		public const int FONT_SIZE_MIN = 4;

		public const int FONT_SIZE_MAX = 200;

		private static List<string> _cachedGraphVisualizationNames;

		private const int METER_TEXTURE_WIDTH = 512;

		private static Texture2D _meterTexture;

		private static Sprite _meterSprite;

		private const int R = 64;

		private static Texture2D _circle32Texture;

		private static Sprite _circle32Sprite;

		public static Color DARK_GREEN;

		public static Color DARK_BLUE;

		public static Color DARK_RED;

		public const float BTTN_LBL_NORM_HGHT = 0.175f;

		private const int BTTN_FONT_SIZE_MAX = 100;

		private const float BTTN_ALPHA = 0.925f;

		private const float GUIDE_MARGIN = 0.01f;

		private const float GUIDE_MARGIN_HALF = 0.005f;

		public static List<string> CachedTelemetryNames => null;

		private static Texture2D MeterTexture => null;

		public static Sprite MeterSprite => null;

		private static Texture2D Circle32Texture => null;

		public static Sprite CircleSprite => null;

		public static bool TryFindActiveRunner(FusionStats fusionStats, out NetworkRunner runner, SimulationModes? mode = null)
		{
			runner = null;
			return false;
		}

		public static RectTransform CreateRectTransform(this Transform parent, string name, bool expand = false)
		{
			return null;
		}

		[Obsolete]
		internal static RectTransform CreateRectTransform(string name, Transform parent, bool expand = false)
		{
			return null;
		}

		public static Dropdown CreateDropdown(this RectTransform rt, float padding, Color fontColor)
		{
			return null;
		}

		public static Text AddText(this RectTransform rt, string label, TextAnchor anchor, Color FontColor)
		{
			return null;
		}

		internal static void MakeButton(this RectTransform parent, ref Button button, string iconText, string labelText, out Text icon, out Text text, UnityAction action)
		{
			icon = null;
			text = null;
		}

		public static RectTransform AddHorizontalLayoutGroup(this RectTransform rt, float spacing, int? rgtPad = null, int? lftPad = null, int? topPad = null, int? botPad = null)
		{
			return null;
		}

		public static RectTransform AddVerticalLayoutGroup(this RectTransform rt, float spacing, int? rgtPad = null, int? lftPad = null, int? topPad = null, int? botPad = null)
		{
			return null;
		}

		public static GridLayoutGroup AddGridlLayoutGroup(this RectTransform rt, float spacing, int? rgtPad = null, int? lftPad = null, int? topPad = null, int? botPad = null)
		{
			return null;
		}

		public static RectTransform AddImage(this RectTransform rt, Color color)
		{
			return null;
		}

		public static RectTransform AddCircleSprite(this RectTransform rt, Color color)
		{
			return null;
		}

		public static RectTransform AddCircleSprite(this RectTransform rt, Color color, out Image image)
		{
			image = null;
			return null;
		}

		public static RectTransform ExpandAnchor(this RectTransform rt, float? padding = null)
		{
			return null;
		}

		public static RectTransform ExpandTopAnchor(this RectTransform rt, float? padding = null)
		{
			return null;
		}

		public static RectTransform ExpandMiddleLeft(this RectTransform rt)
		{
			return null;
		}

		public static RectTransform SetSizeDelta(this RectTransform rt, float offsetX, float offsetY)
		{
			return null;
		}

		public static RectTransform SetOffsets(this RectTransform rt, float minX, float maxX, float minY, float maxY)
		{
			return null;
		}

		public static RectTransform SetPivot(this RectTransform rt, float pivotX, float pivotY)
		{
			return null;
		}

		public static RectTransform SetAnchors(this RectTransform rt, float minX, float maxX, float minY, float maxY)
		{
			return null;
		}

		internal static RectTransform MakeGuides(this RectTransform parent)
		{
			return null;
		}
	}
}
