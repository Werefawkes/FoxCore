namespace Foxthorne.FoxCore
{
	public class VersionNumber
	{
		public VersionPhase Phase { get; private set; }
		public int Major { get; private set; }
		public int Minor { get; private set; }
		public int Patch { get; private set; }
		public int Bugfix { get; private set; }
		public enum VersionPhase
		{
			Alpha,
			Beta,
			PreRelease,
			Release
		}

		public VersionNumber(VersionPhase phase, int major, int minor, int patch, int bugfix = 0)
		{
			Phase = phase;
			Major = major;
			Minor = minor;
			Patch = patch;
			Bugfix = bugfix;
		}

		public override string ToString()
		{
			// Omit the bugfix number if it's not present
			string retval = $"{Phase} v{Major}.{Minor}.{Patch}";
			if (Bugfix > 0)
			{
				retval += "." + Bugfix;
			}

			return retval;
		}
	}
}