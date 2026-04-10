using UnityEngine.UI;

namespace BUSSID
{
	public class GameModeBUSSID : GameModeGame
	{
		public override ReachablePoint SetupGoToButtonsForTestingTool(ReachablePoint targetReachablePoint, Text goToNextTargetBuittonText, Button goToNextTargetButton, Button goToLastTargetButton)
		{
			return null;
		}

		public override void GoToNextTaskPoint(ReachablePoint targetReachablePoint)
		{
		}

		public override bool NeedToDisableCruiseOnEnterPoint(ReachablePoint point)
		{
			return false;
		}
	}
}
