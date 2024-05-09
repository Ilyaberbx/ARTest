using Dexgo.Scripts.Systems.Stencil;
using UnityEngine;

namespace Dexgo.Scripts.Mono
{
    public class StencilsManager : MonoBehaviour, IStencilSystem
    {
        [SerializeField] private MeshRenderer[] _renderers;
        private StencilSystem _stencilSystem;

        private void Awake() => _stencilSystem = new StencilSystem(_renderers);

        #region IStencilSystem
        
        public void SetComparison(ComparisonOperation comparison) => _stencilSystem.SetComparison(comparison);
        
        #endregion
    }
}