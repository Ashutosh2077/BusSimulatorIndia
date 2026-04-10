using Fusion;
using UnityEngine;

[ScriptHelp(BackColor = EditorHeaderBackColor.Steel)]
[NetworkBehaviourWeaved(3)]
public class ControllerPrototype : NetworkBehaviour
{
	protected NetworkCharacterControllerPrototype _ncc;

	protected NetworkRigidbody _nrb;

	protected NetworkRigidbody2D _nrb2d;

	protected NetworkTransform _nt;

	[SerializeField]
	[DefaultForProperty("MovementDirection", 0, 3)]
	private Vector3 _MovementDirection;

	public bool TransformLocal;

	[DrawIf("ShowSpeed", Hide = true)]
	public float Speed;

	private static Changed<ControllerPrototype> _0024IL2CPP_CHANGED;

	private static ChangedDelegate<ControllerPrototype> _0024IL2CPP_CHANGED_DELEGATE;

	private static NetworkBehaviourCallbacks<ControllerPrototype> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

	[Networked]
	[NetworkedWeaved(0, 3)]
	public Vector3 MovementDirection
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	private bool ShowSpeed => false;

	public void Awake()
	{
	}

	public override void Spawned()
	{
	}

	private void CacheComponents()
	{
	}

	public override void FixedUpdateNetwork()
	{
	}

	public override void CopyBackingFieldsToState(bool P_0)
	{
	}

	public override void CopyStateToBackingFields()
	{
	}
}
