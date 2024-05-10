using Dexgo.Scripts.Systems;
using UnityEngine;

namespace Dexgo.Scripts.Mono
{
    public class StencilManager : MonoBehaviour, IStencilSystem
    {
        [SerializeField] private MeshRenderer[] _renderers;
        [SerializeField] private ContextObserver _contextObserver;
        
        private StencilSystem _stencilSystem;
        private ComparisonOperation _comparisonOperation = ComparisonOperation.Equal;
        private void Awake() => _stencilSystem = new StencilSystem(_renderers);

        private void Start() => _contextObserver.OnEnter += OnContextEntered;

        private void OnDestroy() => _contextObserver.OnEnter -= OnContextEntered;

        private void OnContextEntered(Context context)
        {
            _comparisonOperation = _comparisonOperation == ComparisonOperation.Equal
                ? ComparisonOperation.NotEqual
                : ComparisonOperation.Equal;
            
            SetComparison(_comparisonOperation);
        }

        #region IStencilSystem

        public void SetComparison(ComparisonOperation comparison) => _stencilSystem.SetComparison(comparison);

        #endregion
    }
}