using UnityEngine;

public static class FusionScalableIMGUI
{
	private static GUISkin _scalableSkin;

	private static void InitializedGUIStyles(GUISkin baseSkin)
	{
	}

	public static GUISkin GetScaledSkin(GUISkin baseSkin, out float height, out float width, out int padding, out int margin, out float boxLeft)
	{
		height = default(float);
		width = default(float);
		padding = default(int);
		margin = default(int);
		boxLeft = default(float);
		return null;
	}

	public static (float, float, int, int, float) ScaleGuiSkinToScreenHeight()
	{
		return default((float, float, int, int, float));
	}
}
