using System.Diagnostics.CodeAnalysis;

using IG.HappyCoder.Dramework3.Runtime.Container.Attributes.Creation;
using IG.HappyCoder.Dramework3.Runtime.Container.Core;

// ReSharper disable once RedundantUsingDirective
using UnityEngine;
using _Project.Modules.Lobby.Circle.Runtime.Models;

namespace _Project.Modules.Lobby.Circle
{
	[Installer("Lobby", 1, "Circle")]
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
				new DInstallData(new CircleModel(
								GetAsset<GameObject>(typeof(CircleModel), "Lobby", "CirclePrefabs", "Circle")), true, ""),
			};
		}

		public override DInstallData[] CreateSystems()
		{
			return new DInstallData[]
			{
			};
		}
	}
}