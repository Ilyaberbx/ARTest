using System.Collections.Generic;
using UnityEngine;

namespace Dexgo.Scripts.Systems.Stencil
{
    public class StencilSystem : IStencilSystem
    {
        private static readonly int StencilComparison = Shader.PropertyToID("_StencilComparison");
        
        private readonly IReadOnlyCollection<MeshRenderer> _renderers;

        public StencilSystem(IReadOnlyCollection<MeshRenderer> renderers)
        {
            _renderers = renderers;
        }

        public void SetComparison(ComparisonOperation comparison)
        {
            foreach (var renderer in _renderers)
            {
                var propertyBlock = new MaterialPropertyBlock();
                
                propertyBlock.SetInt(StencilComparison, (int)comparison);
                
                renderer.SetPropertyBlock(propertyBlock);
            }
        }
    }
}