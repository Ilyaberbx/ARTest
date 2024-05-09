using System;
using UnityEngine;

namespace Dexgo.Scripts.Mono.Commons
{
    [RequireComponent(typeof(Collider))]
    public abstract class TriggerObserver<TComponent> : MonoBehaviour where TComponent : Component
    {
        public event Action<TComponent> OnEnter;
        public event Action<TComponent> OnExit;
        public event Action<TComponent> OnStay;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out TComponent component))
            {
                OnEnter?.Invoke(component);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent(out TComponent component))
            {
                OnExit?.Invoke(component);
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.TryGetComponent(out TComponent component))
            {
                OnStay?.Invoke(component);
            }
        }
    }
}