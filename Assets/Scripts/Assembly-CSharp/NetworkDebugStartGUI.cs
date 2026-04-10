using System;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

[AddComponentMenu("Fusion/Network Debug Start GUI")]
[ScriptHelp(BackColor = EditorHeaderBackColor.Steel)]
[RequireComponent(typeof(NetworkDebugStart))]
public class NetworkDebugStartGUI : Fusion.Behaviour
{
	[InlineHelp]
	public bool EnableHotkeys;

	[InlineHelp]
	public GUISkin BaseSkin;

	private NetworkDebugStart _networkDebugStart;

	private string _clientCount;

	private bool _isMultiplePeerMode;

	private Dictionary<NetworkDebugStart.Stage, string> _nicifiedStageNames;

	protected virtual void OnValidate()
	{
	}

	protected void ValidateClientCount()
	{
	}

	protected int GetClientCount()
	{
		return 0;
	}

	protected virtual void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	protected NetworkDebugStart EnsureNetworkDebugStartExists()
	{
		return null;
	}

	private void Update()
	{
	}

	protected virtual void OnGUI()
	{
	}

	private void StartHostWithClients(NetworkDebugStart nds)
	{
	}

	private void StartServerWithClients(NetworkDebugStart nds)
	{
	}

	private void StartMultipleClients(NetworkDebugStart nds)
	{
	}

	private void StartMultipleAutoClients(NetworkDebugStart nds)
	{
	}

	private void StartMultipleSharedClients(NetworkDebugStart nds)
	{
	}

	public static Dictionary<T, string> ConvertEnumToNicifiedNameLookup<T>(string prefix = null, Dictionary<T, string> nonalloc = null) where T : Enum
	{
		return null;
	}
}
