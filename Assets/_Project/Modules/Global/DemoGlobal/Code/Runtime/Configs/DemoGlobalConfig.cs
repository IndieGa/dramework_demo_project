using IG.HappyCoder.Dramework3.Runtime.Core;

using UnityEngine;


namespace _Project.Modules.Global.DemoGlobal.Runtime.Configs
{
    [CreateAssetMenu(menuName = "Project/Configs/Global/Demo Config", fileName = "Demo Config")]
    internal class DemoGlobalConfig : DConfig
    {
        #region ================================ FIELDS

        [SerializeField]
        private int _squareCount;

        #endregion

        #region ================================ PROPERTIES AND INDEXERS

        internal int SquareCount => _squareCount;

        #endregion
    }
}