using _Project.Core.Runtime.Interfaces;
using _Project.Modules.Lobby.Square.Runtime.Models;

using Cysharp.Threading.Tasks;

using IG.HappyCoder.Dramework3.Runtime.Container.Attributes.Creation;
using IG.HappyCoder.Dramework3.Runtime.Container.Interfaces.Controlling;

using UnityEngine;


namespace _Project.Modules.Lobby.Square.Runtime.Systems
{
    [CreateSystem]
    internal class SquareSystem : IStartable
    {
        #region ================================ FIELDS

        private readonly IDemoGlobal _demoGlobal;
        private readonly SquareModel _model;
        private readonly ICircle _circle;

        #endregion

        #region ================================ CONSTRUCTORS AND DESTRUCTOR

        public SquareSystem(IDemoGlobal demoGlobal, SquareModel model, ICircle circle)
        {
            _demoGlobal = demoGlobal;
            _model = model;
            _circle = circle;
        }

        #endregion

        #region ================================ METHODS

        async UniTask IStartable.OnStart()
        {
            await UniTask.Delay(3000);
            Object.Destroy(_circle.Circle);

            for (var i = 0; i < _demoGlobal.SquareCount; i++)
            {
                var go = Object.Instantiate(_model.SquarePrefab);
                go.transform.position = new Vector3(Random.Range(-2, 2), 0, 10);
            }
        }

        #endregion
    }
}