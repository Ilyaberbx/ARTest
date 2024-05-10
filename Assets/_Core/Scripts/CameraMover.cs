using UnityEngine;

namespace Dexgo.Scripts
{
    public class CameraMover : MonoBehaviour
    {
        [SerializeField] private Transform _camera;
        
        private void Update()
        {
            float speed = 0.03f;
            
            if (Input.GetKey(KeyCode.A))
            {
                _camera.Translate(Vector3.left * speed);
            }
            
            if (Input.GetKey(KeyCode.D))
            {
                _camera.Translate(Vector3.right * speed);
            }
            
            if (Input.GetKey(KeyCode.W))
            {
                _camera.Translate(Vector3.up * speed);
            }
            
            if (Input.GetKey(KeyCode.S))
            {
                _camera.Translate(Vector3.down * speed);
            }
            
            if (Input.GetKey(KeyCode.Space))
            {
                _camera.Translate(Vector3.forward * speed);
            }
            
            if (Input.GetKey(KeyCode.LeftShift))
            {
                _camera.Translate(Vector3.back * speed);
            }
        }
    }
}