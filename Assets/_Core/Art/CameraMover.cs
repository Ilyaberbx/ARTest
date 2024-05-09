using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private Transform _camera;
    private float _speed;

    private void Update()
    {
        _speed = 0.2f;
        
        if (Input.GetKey(KeyCode.A))
        {
            _camera.Translate(Vector3.left * _speed);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            _camera.Translate(Vector3.down * _speed);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            _camera.Translate(Vector3.right * _speed);
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            _camera.Translate(Vector3.up * _speed);
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            _camera.Translate(Vector3.forward * _speed);
        }
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            _camera.Translate(Vector3.back * _speed);
        }
    }
}
