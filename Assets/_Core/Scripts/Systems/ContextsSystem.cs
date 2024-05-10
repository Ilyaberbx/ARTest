using Dexgo.Scripts.Mono;
using UnityEngine;

namespace Dexgo.Scripts.Systems
{
    public class ContextsSystem 
    {
        private readonly Transform _target;
        private readonly float _minDistanceToChange;

        private Vector3 TargetPosition => _target.position;
        
        public ContextsSystem(Transform target, float minDistanceToChange)
        {
            _target = target;
            _minDistanceToChange = minDistanceToChange;
        }
        
        public bool TryChangeContext(Context context)
        {
            var position = context.transform.position;

            return Vector3.Distance(TargetPosition, position) > _minDistanceToChange;
        }
    }
}