using System.Collections.Generic;
using UnityEngine;

namespace Dexgo.Scripts.Systems
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
                foreach (var material in renderer.sharedMaterials)
                {
                    material.SetInt(StencilComparison, (int)comparison);
                }
            }
        }
    }
}