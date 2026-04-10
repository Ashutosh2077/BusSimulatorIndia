using System.Collections.Generic;
using Fusion;
using UnityEngine;

[ScriptHelp(BackColor = EditorHeaderBackColor.Steel)]
public class SpawnerPrototype<T> : SimulationBehaviour, IPlayerJoined, IPlayerLeft, ISpawned, ISceneLoadDone where T : Component, ISpawnPointPrototype
{
	public enum SpawnMethods
	{
		AutoOnNetworkStart = 0,
		ByScriptOnly = 1
	}

	public enum AuthorityOptions
	{
		Auto = 0,
		Server = 1,
		Player = 2
	}

	protected Dictionary<PlayerRef, List<NetworkObject>> _spawnedLookup;

	[InlineHelp]
	public NetworkObject PlayerPrefab;

	[InlineHelp]
	public SpawnMethods SpawnMethod;

	[InlineHelp]
	[DrawIf("_AllowClientObjects", Hide = true)]
	[MultiPropertyDrawersFix]
	public AuthorityOptions StateAuthority;

	protected ISpawnPointManagerPrototype<T> spawnManager;

	protected bool _AllowClientObjects => false;

	protected virtual void Awake()
	{
	}

	public void Spawned()
	{
	}

	public void SceneLoadDone()
	{
	}

	public void PlayerJoined(PlayerRef player)
	{
	}

	public void PlayerLeft(PlayerRef player)
	{
	}

	private void PlayerJoined(NetworkRunner runner, PlayerRef player)
	{
	}

	private void PlayerLeft(NetworkRunner runner, PlayerRef player)
	{
	}

	public NetworkObject TrySpawn(NetworkRunner runner, PlayerRef player)
	{
		return null;
	}

	[BehaviourButtonAction("Spawn For All Players On Server", true, false, null)]
	public void TrySpawnAll()
	{
	}

	protected virtual void RegisterPlayerAndObject(PlayerRef player, NetworkObject playerObject)
	{
	}

	protected void DespawnPlayersObjects(NetworkRunner runner, PlayerRef player)
	{
	}

	protected void UnregisterPlayer(PlayerRef player)
	{
	}
}
