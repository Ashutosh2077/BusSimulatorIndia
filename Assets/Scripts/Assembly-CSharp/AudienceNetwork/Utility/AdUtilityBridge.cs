namespace AudienceNetwork.Utility
{
	internal class AdUtilityBridge : IAdUtilityBridge
	{
		public static readonly IAdUtilityBridge Instance;

		internal AdUtilityBridge()
		{
		}

		static AdUtilityBridge()
		{
		}

		private static IAdUtilityBridge CreateInstance()
		{
			return null;
		}

		public virtual double DeviceWidth()
		{
			return 0.0;
		}

		public virtual double DeviceHeight()
		{
			return 0.0;
		}

		public virtual double Width()
		{
			return 0.0;
		}

		public virtual double Height()
		{
			return 0.0;
		}

		public virtual double Convert(double deviceSize)
		{
			return 0.0;
		}

		public virtual void Prepare()
		{
		}
	}
}
