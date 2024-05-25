using System.Diagnostics.CodeAnalysis;

using IG.HappyCoder.Dramework3.Runtime.Container.Attributes.Creation;
using IG.HappyCoder.Dramework3.Runtime.Container.Core;

// ReSharper disable once RedundantUsingDirective
using UnityEngine;
using _Project.Modules.Global.DemoGlobal.Runtime.Systems;
using _Project.Modules.Global.DemoGlobal.Runtime.Models;
using _Project.Modules.Global.DemoGlobal.Runtime.Configs;
using _Project.Modules.Global.DemoGlobal.Runtime.Views;

namespace _Project.Modules.Global.DemoGlobal.Runtime
{
	[Installer("Global", 1, "DemoGlobal")]
	[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
	[SuppressMessage("ReSharper", "UnusedType.Global")]
	[SuppressMessage("ReSharper", "RedundantExplicitArrayCreation")]
	internal class AssemblyInstaller : DInstaller
	{
		public override DInstallData[] CreateFactories()
		{
			return new DInstallData[]
			{
			};
		}

		public override DInstallData[] CreateModels()
		{
			return new DInstallData[]
			{
				new DInstallData(new DemoGlobalModel(
								GetAsset<DemoGlobalConfig>(typeof(DemoGlobalModel), "Global", "Configs", "DemoConfig"), 
								GetObject<DemoGlobalView>()), true, ""),
			};
		}

		public override DInstallData[] CreateSystems()
		{
			return new DInstallData[]
			{
				new DInstallData(new DemoGlobalSystem(
								GetObject<DemoGlobalModel>()), false, ""),
			};
		}
	}
}