using IG.HappyCoder.Dramework3.Runtime.Container.Attributes.Injection;
using IG.HappyCoder.Dramework3.Runtime.Initialization.Attributes.Getting;
using IG.HappyCoder.Dramework3.Runtime.UI.UGUI.Base;
using IG.HappyCoder.Dramework3.Runtime.UI.UGUI.Elements;

using Sirenix.OdinInspector;

using UnityEngine;


namespace _Project.Modules.Global.DemoGlobal.Runtime.Views
{
    [Bind]
    internal class DemoGlobalView : DUIBehaviour
    {
        #region ================================ FIELDS

        [FoldoutGroup("Components")] [BoxGroup("Components/Button", false)]
        [SerializeField] [GetComponentInChildren]
        private DButton _button;

        #endregion

        #region ================================ PROPERTIES AND INDEXERS

        internal DButton Button => _button;

        #endregion
    }
}