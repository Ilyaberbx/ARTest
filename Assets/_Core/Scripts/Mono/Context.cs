using Dexgo.Scripts.Systems.Stencil;
using UnityEngine;

namespace Dexgo.Scripts.Mono
{
    public class Context : MonoBehaviour
    {
        [SerializeField] private ComparisonOperation _comparison;

        public ComparisonOperation Comparison => _comparison;
    }
}