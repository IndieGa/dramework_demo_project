using _Project.Core.Runtime.Interfaces;

using Cysharp.Threading.Tasks;

using IG.HappyCoder.Dramework3.Runtime.Container.Attributes.Creation;
using IG.HappyCoder.Dramework3.Runtime.Container.Attributes.Injection;
using IG.HappyCoder.Dramework3.Runtime.Container.Interfaces.Initialization;
using IG.HappyCoder.Dramework3.Runtime.Core;
using IG.HappyCoder.Dramework3.Runtime.Generated.GameResources;

using UnityEngine;


namespace _Project.Modules.Lobby.Circle.Runtime.Models
{
    [CreateModel] [Bind]
    internal class CircleModel : ICircle, IEarlyInitializable
    {
        #region ================================ FIELDS

        private readonly GameObject _prefab;

        #endregion

        #region ================================ CONSTRUCTORS AND DESTRUCTOR

        public CircleModel
        (
            [InjectAsset(GR.Lobby.CirclePrefabs.Circle)]
            GameObject prefab
        )
        {
            _prefab = prefab;
        }

        #endregion

        #region ================================ PROPERTIES AND INDEXERS

        public GameObject Circle { get; private set; }

        #endregion

        #region ================================ METHODS

        UniTask IEarlyInitializable.OnEarlyInitialize()
        {
            Circle = Object.Instantiate(_prefab);
            Circle.transform.position = new Vector3(0, 0, 10);
            return DReturn.CompletedTask;
        }

        #endregion
    }
}