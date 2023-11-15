using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _shooter;
    [SerializeField] private GameObject _projectile;
    [SerializeField] private float _secondsBetweenShots;

    private float _time;

    private void LateUpdate()
    {
        if (Time.time > _time)
        {
            Shot();
            _time = Time.time + _secondsBetweenShots;
        }
    }
    private void Shot()
    {
        Instantiate(_projectile, new Vector3(this.GetComponent<Rigidbody2D>().position.x, this.GetComponent<Rigidbody2D>().position.y), _shooter.transform.rotation);
    }
}
