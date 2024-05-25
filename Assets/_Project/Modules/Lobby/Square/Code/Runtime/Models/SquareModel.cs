using System;

using Cysharp.Threading.Tasks;

using IG.HappyCoder.Dramework3.Runtime.Container.Attributes.Creation;
using IG.HappyCoder.Dramework3.Runtime.Container.Attributes.Injection;
using IG.HappyCoder.Dramework3.Runtime.Container.Interfaces.Initialization;
using IG.HappyCoder.Dramework3.Runtime.Generated.GameResources;
using IG.HappyCoder.Dramework3.Runtime.ResourceManagement;

using UnityEngine;


namespace _Project.Modules.Lobby.Square.Runtime.Models
{
    [CreateModel] [Bind]
    internal class SquareModel : IEarlyInitializable, IDisposable
    {
        #region ================================ FIELDS

        private readonly IResource _rPrefab;

        private GameObject _prefab;

        #endregion

        #region ================================ CONSTRUCTORS AND DESTRUCTOR

        internal SquareModel
        (
            [InjectResource(GR.Lobby.SquarePrefabs.Square)]
            IResource rPrefab
        )
        {
            _rPrefab = rPrefab;
        }

        #endregion

        #region ================================ PROPERTIES AND INDEXERS

        internal GameObject SquarePrefab => _prefab;

        #endregion

        #region ================================ METHODS

        void IDisposable.Dispose()
        {
            ReleaseResources();
        }

        private async UniTask InitializeResources()
        {
            _prefab = await _rPrefab.LoadAsync<GameObject>();
        }

        async UniTask IEarlyInitializable.OnEarlyInitialize()
        {
            await InitializeResources();
        }

        private void ReleaseResources()
        {
            _rPrefab.Release();
        }

        #endregion
    }
}