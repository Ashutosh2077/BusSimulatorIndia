using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.SceneManagement;

namespace Fusion
{
	public abstract class NetworkSceneManagerBase : Behaviour, INetworkSceneManager
	{
		protected delegate void FinishedLoadingDelegate(IEnumerable<NetworkObject> sceneObjects);

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass28_0
		{
			public bool finishCalled;

			public Dictionary<Guid, NetworkObject> sceneObjects;

			internal void _003CSwitchSceneWrapper_003Eb__0(IEnumerable<NetworkObject> objects)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CSwitchSceneWrapper_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NetworkSceneManagerBase _003C_003E4__this;

			public SceneRef prevScene;

			public SceneRef newScene;

			private _003C_003Ec__DisplayClass28_0 _003C_003E8__1;

			private Exception _003Cerror_003E5__2;

			private IEnumerator _003Ccoro_003E5__3;

			private bool _003Cnext_003E5__4;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSwitchSceneWrapper_003Ed__28(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private static WeakReference<NetworkSceneManagerBase> s_currentlyLoading;

		[InlineHelp]
		[ToggleLeft]
		[MultiPropertyDrawersFix]
		public bool ShowHierarchyWindowOverlay;

		private IEnumerator _runningCoroutine;

		private bool _currentSceneOutdated;

		private SceneRef _currentScene;

		public NetworkRunner Runner { get; private set; }

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		public static bool IsScenePathOrNameEqual(Scene scene, string nameOrPath)
		{
			return false;
		}

		public static bool TryGetScenePathFromBuildSettings(SceneRef sceneRef, out string path)
		{
			path = null;
			return false;
		}

		public virtual bool TryGetScenePath(SceneRef sceneRef, out string path)
		{
			path = null;
			return false;
		}

		public virtual bool TryGetSceneRef(string nameOrPath, out SceneRef sceneRef)
		{
			sceneRef = default(SceneRef);
			return false;
		}

		public bool IsScenePathOrNameEqual(Scene scene, SceneRef sceneRef)
		{
			return false;
		}

		public List<NetworkObject> FindNetworkObjects(Scene scene, bool disable = true, bool addVisibilityNodes = false)
		{
			return null;
		}

		void INetworkSceneManager.Initialize(NetworkRunner runner)
		{
		}

		void INetworkSceneManager.Shutdown(NetworkRunner runner)
		{
		}

		bool INetworkSceneManager.IsReady(NetworkRunner runner)
		{
			return false;
		}

		protected virtual void Initialize(NetworkRunner runner)
		{
		}

		protected virtual void Shutdown(NetworkRunner runner)
		{
		}

		protected abstract IEnumerator SwitchScene(SceneRef prevScene, SceneRef newScene, FinishedLoadingDelegate finished);

		[Conditional("FUSION_NETWORK_SCENE_MANAGER_TRACE")]
		protected void LogTrace(string msg)
		{
		}

		protected void LogError(string msg)
		{
		}

		protected void LogWarn(string msg)
		{
		}

		[IteratorStateMachine(typeof(_003CSwitchSceneWrapper_003Ed__28))]
		private IEnumerator SwitchSceneWrapper(SceneRef prevScene, SceneRef newScene)
		{
			return null;
		}
	}
}
