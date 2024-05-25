using _Project.Core.Runtime.Interfaces;
using _Project.Modules.Global.DemoGlobal.Runtime.Configs;
using _Project.Modules.Global.DemoGlobal.Runtime.Views;

using IG.HappyCoder.Dramework3.Runtime.Container.Attributes.Creation;
using IG.HappyCoder.Dramework3.Runtime.Container.Attributes.Injection;
using IG.HappyCoder.Dramework3.Runtime.Generated.GameResources;
using IG.HappyCoder.Dramework3.Runtime.UI.UGUI.Elements;


namespace _Project.Modules.Global.DemoGlobal.Runtime.Models
{
    [CreateModel] [Bind]
    internal class DemoGlobalModel : IDemoGlobal
    {
        #region ================================ FIELDS

        private readonly DemoGlobalConfig _config;
        private readonly DemoGlobalView _view;

        #endregion

        #region ================================ CONSTRUCTORS AND DESTRUCTOR

        internal DemoGlobalModel
        (
            [InjectAsset(GR.Global.Configs.DemoConfig)]
            DemoGlobalConfig config,
            DemoGlobalView view
        )
        {
            _config = config;
            _view = view;
        }

        #endregion

        #region ================================ PROPERTIES AND INDEXERS

        internal DButton Button => _view.Button;
        int IDemoGlobal.SquareCount => _config.SquareCount;

        #endregion

        #region ================================ METHODS

        internal void HideScreen()
        {
            _view.Hide();
        }

        #endregion
    }
}