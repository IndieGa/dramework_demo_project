using System;

using _Project.Modules.Global.DemoGlobal.Runtime.Models;

using Cysharp.Threading.Tasks;

using IG.HappyCoder.Dramework3.Runtime.Container.Attributes.Creation;
using IG.HappyCoder.Dramework3.Runtime.Container.Interfaces.Initialization;
using IG.HappyCoder.Dramework3.Runtime.Core;
using IG.HappyCoder.Dramework3.Runtime.Generated.Scenes;

using UnityEngine.SceneManagement;


namespace _Project.Modules.Global.DemoGlobal.Runtime.Systems
{
    [CreateSystem]
    internal class DemoGlobalSystem : IInitializable, IDisposable
    {
        #region ================================ FIELDS

        private readonly DemoGlobalModel _model;

        #endregion

        #region ================================ CONSTRUCTORS AND DESTRUCTOR

        internal DemoGlobalSystem(DemoGlobalModel model)
        {
            _model = model;
        }

        #endregion

        #region ================================ METHODS

        void IDisposable.Dispose()
        {
            _model.Button.onClick -= LoadSceneLobby;
        }

        private void LoadSceneLobby()
        {
            _model.HideScreen();
            SceneManager.LoadScene(SceneName.Lobby, LoadSceneMode.Single);
        }

        UniTask IInitializable.OnInitialize()
        {
            _model.Button.onClick += LoadSceneLobby;
            return DReturn.CompletedTask;
        }

        #endregion
    }
}