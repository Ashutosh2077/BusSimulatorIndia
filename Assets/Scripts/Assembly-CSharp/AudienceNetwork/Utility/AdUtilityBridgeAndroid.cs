namespace AudienceNetwork.Utility
{
	internal class AdUtilityBridgeAndroid : AdUtilityBridge
	{
		private T GetPropertyOfDisplayMetrics<T>(string property)
		{
			return default(T);
		}

		private double Density()
		{
			return 0.0;
		}

		public override double DeviceWidth()
		{
			return 0.0;
		}

		public override double DeviceHeight()
		{
			return 0.0;
		}

		public override double Width()
		{
			return 0.0;
		}

		public override double Height()
		{
			return 0.0;
		}

		public override double Convert(double deviceSize)
		{
			return 0.0;
		}

		public override void Prepare()
		{
		}
	}
}
