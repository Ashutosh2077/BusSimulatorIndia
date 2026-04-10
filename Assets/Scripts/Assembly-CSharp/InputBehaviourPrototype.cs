using System;
using System.Collections.Generic;
using Fusion;
using Fusion.Sockets;

[ScriptHelp(BackColor = EditorHeaderBackColor.Steel)]
public class InputBehaviourPrototype : Behaviour, INetworkRunnerCallbacks
{
	public void OnInput(NetworkRunner runner, NetworkInput input)
	{
	}

	public void OnInputMissing(NetworkRunner runner, PlayerRef player, NetworkInput input)
	{
	}

	public void OnConnectedToServer(NetworkRunner runner)
	{
	}

	public void OnConnectFailed(NetworkRunner runner, NetAddress remoteAddress, NetConnectFailedReason reason)
	{
	}

	public void OnConnectRequest(NetworkRunner runner, NetworkRunnerCallbackArgs.ConnectRequest request, byte[] token)
	{
	}

	public void OnDisconnectedFromServer(NetworkRunner runner)
	{
	}

	public void OnPlayerJoined(NetworkRunner runner, PlayerRef player)
	{
	}

	public void OnPlayerLeft(NetworkRunner runner, PlayerRef player)
	{
	}

	public void OnUserSimulationMessage(NetworkRunner runner, SimulationMessagePtr message)
	{
	}

	public void OnShutdown(NetworkRunner runner, ShutdownReason shutdownReason)
	{
	}

	public void OnSessionListUpdated(NetworkRunner runner, List<SessionInfo> sessionList)
	{
	}

	public void OnReliableDataReceived(NetworkRunner runner, PlayerRef player, ArraySegment<byte> data)
	{
	}

	public void OnSceneLoadDone(NetworkRunner runner)
	{
	}

	public void OnSceneLoadStart(NetworkRunner runner)
	{
	}

	public void OnCustomAuthenticationResponse(NetworkRunner runner, Dictionary<string, object> data)
	{
	}

	public void OnHostMigration(NetworkRunner runner, HostMigrationToken hostMigrationToken)
	{
	}
}
