using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Exclusive_injector.Properties
{
	[DebuggerNonUserCode]
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	internal class Resources
	{
		private static ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (resourceMan == null)
				{
					resourceMan = new ResourceManager("Exclusive_injector.Properties.Resources", typeof(Resources).Assembly);
				}
				return resourceMan;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return resourceCulture;
			}
			set
			{
				resourceCulture = value;
			}
		}

		internal static byte[] Arg_Jnjector_x86 => (byte[])ResourceManager.GetObject("Arg_Jnjector_x86", resourceCulture);

		internal static byte[] artbgfile => (byte[])ResourceManager.GetObject("artbgfile", resourceCulture);

		internal static byte[] Exclusive_csgo => (byte[])ResourceManager.GetObject("Exclusive_csgo", resourceCulture);

		internal static byte[] GOTHIC => (byte[])ResourceManager.GetObject("GOTHIC", resourceCulture);

		internal static byte[] GOTHICI => (byte[])ResourceManager.GetObject("GOTHICI", resourceCulture);

		internal static Icon logo_ex_circle => (Icon)ResourceManager.GetObject("logo_ex_circle", resourceCulture);

		internal Resources()
		{
		}
	}
}
