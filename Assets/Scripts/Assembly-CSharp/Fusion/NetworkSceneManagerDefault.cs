using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Fusion
{
	public class NetworkSceneManagerDefault : NetworkSceneManagerBase
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			public Scene loadedScene;

			internal void _003CSwitchSceneMultiplePeer_003Eb__0(Scene scene)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CSwitchSceneMultiplePeer_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SceneRef prevScene;

			public NetworkSceneManagerDefault _003C_003E4__this;

			public SceneRef newScene;

			private _003C_003Ec__DisplayClass4_0 _003C_003E8__1;

			public FinishedLoadingDelegate finished;

			private LoadSceneParameters _003CloadSceneParameters_003E5__2;

			private Scene _003CsceneToUnload_003E5__3;

			private GameObject[] _003CtempSceneSpawnedPrefabs_003E5__4;

			private List<NetworkObject> _003CsceneObjects_003E5__5;

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
			public _003CSwitchSceneMultiplePeer_003Ed__4(int _003C_003E1__state)
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

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public Scene loadedScene;

			internal void _003CSwitchSceneSinglePeer_003Eb__0(Scene scene)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CSwitchSceneSinglePeer_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SceneRef prevScene;

			public NetworkSceneManagerDefault _003C_003E4__this;

			public SceneRef newScene;

			private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

			public FinishedLoadingDelegate finished;

			private int _003Ci_003E5__2;

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
			public _003CSwitchSceneSinglePeer_003Ed__5(int _003C_003E1__state)
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

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Header("Single Peer Options")]
		public int PostLoadDelayFrames;

		protected virtual YieldInstruction LoadSceneAsync(SceneRef sceneRef, LoadSceneParameters parameters, Action<Scene> loaded)
		{
			return null;
		}

		protected virtual YieldInstruction UnloadSceneAsync(Scene scene)
		{
			return null;
		}

		protected override IEnumerator SwitchScene(SceneRef prevScene, SceneRef newScene, FinishedLoadingDelegate finished)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSwitchSceneMultiplePeer_003Ed__4))]
		protected virtual IEnumerator SwitchSceneMultiplePeer(SceneRef prevScene, SceneRef newScene, FinishedLoadingDelegate finished)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSwitchSceneSinglePeer_003Ed__5))]
		protected virtual IEnumerator SwitchSceneSinglePeer(SceneRef prevScene, SceneRef newScene, FinishedLoadingDelegate finished)
		{
			return null;
		}
	}
}
