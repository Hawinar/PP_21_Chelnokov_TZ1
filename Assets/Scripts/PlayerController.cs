using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    private float _rotation = 0f;

    private void Update()
    {
        _rotation = Input.GetAxis("Horizontal") * _rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, 0f, _rotation);
    }
}
