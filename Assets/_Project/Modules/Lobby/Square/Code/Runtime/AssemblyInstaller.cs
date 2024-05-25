using System.Diagnostics.CodeAnalysis;

using IG.HappyCoder.Dramework3.Runtime.Container.Attributes.Creation;
using IG.HappyCoder.Dramework3.Runtime.Container.Core;

// ReSharper disable once RedundantUsingDirective
using UnityEngine;
using _Project.Modules.Lobby.Square.Runtime.Systems;
using _Project.Core.Runtime.Interfaces;
using _Project.Modules.Lobby.Square.Runtime.Models;
using IG.HappyCoder.Dramework3.Runtime.ResourceManagement;

namespace _Project.Modules.Lobby.Square.Runtime
{
	[Installer("Lobby", 2, "Square")]
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
				new DInstallData(new SquareModel(
								GetResource(typeof(SquareModel), "Lobby", "SquarePrefabs", "Square")), true, ""),
			};
		}

		public override DInstallData[] CreateSystems()
		{
			return new DInstallData[]
			{
				new DInstallData(new SquareSystem(
								GetObject<IDemoGlobal>(), 
								GetObject<SquareModel>(), 
								GetObject<ICircle>()), false, ""),
			};
		}
	}
}