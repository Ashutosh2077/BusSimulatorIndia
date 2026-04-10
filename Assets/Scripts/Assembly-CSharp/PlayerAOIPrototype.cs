using Fusion;
using UnityEngine;

[ScriptHelp(BackColor = EditorHeaderBackColor.Steel)]
[NetworkBehaviourWeaved(0)]
public class PlayerAOIPrototype : NetworkBehaviour
{
	[SerializeField]
	[MultiPropertyDrawersFix]
	[InlineHelp]
	protected bool DrawAreaOfInterestRadius;

	[InlineHelp]
	public float Radius;

	private static Changed<PlayerAOIPrototype> _0024IL2CPP_CHANGED;

	private static ChangedDelegate<PlayerAOIPrototype> _0024IL2CPP_CHANGED_DELEGATE;

	private static NetworkBehaviourCallbacks<PlayerAOIPrototype> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

	public override void FixedUpdateNetwork()
	{
	}

	private void OnDrawGizmos()
	{
	}

	public override void CopyBackingFieldsToState(bool P_0)
	{
	}

	public override void CopyStateToBackingFields()
	{
	}
}
