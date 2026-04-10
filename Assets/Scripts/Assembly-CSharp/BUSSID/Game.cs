using UnityEngine;

namespace BUSSID
{
	[CreateAssetMenu(fileName = "GameBUSSID", menuName = "BUSSID/GameBUSSID")]
	public class Game : GameBase
	{
		public override void ResetAllGameModesState()
		{
		}

		public override GameMode GetGameModeByClassName(string className)
		{
			return null;
		}

		public override GameMode GetFreeGameMode()
		{
			return null;
		}

		public override GameMode GetCareerGameMode()
		{
			return null;
		}

		public override GameMode GetTourGameMode()
		{
			return null;
		}

		public override GameMode GetStreetGameMode()
		{
			return null;
		}

		public override GameMode GetMultiplayerGameMode()
		{
			return null;
		}
	}
}
