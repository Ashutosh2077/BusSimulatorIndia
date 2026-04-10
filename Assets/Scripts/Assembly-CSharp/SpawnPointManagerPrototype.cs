using System;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

[ScriptHelp(BackColor = EditorHeaderBackColor.Steel)]
public abstract class SpawnPointManagerPrototype<T> : Fusion.Behaviour, ISpawnPointManagerPrototype<T> where T : Component, ISpawnPointPrototype
{
	public enum SpawnSequence
	{
		PlayerId = 0,
		RoundRobin = 1,
		Random = 2
	}

	[InlineHelp]
	public SpawnSequence Sequence;

	[InlineHelp]
	public LayerMask BlockingLayers;

	[InlineHelp]
	public float BlockedCheckRadius;

	[NonSerialized]
	internal List<Component> _spawnPoints;

	[NonSerialized]
	public int LastSpawnIndex;

	private NetworkRNG rng;

	protected static Collider[] blocked3D;

	private void Awake()
	{
	}

	public void CollectSpawnPoints(NetworkRunner runner)
	{
	}

	public virtual Transform GetNextSpawnPoint(NetworkRunner runner, PlayerRef player, bool skipIfBlocked = true)
	{
		return null;
	}

	public virtual Transform AllSpawnPointsBlockedFallback()
	{
		return null;
	}

	public virtual (int, Component) GetNextUnblocked(int failedIndex)
	{
		return default((int, Component));
	}

	public virtual bool IsBlocked(Component spawnPoint)
	{
		return false;
	}
}
