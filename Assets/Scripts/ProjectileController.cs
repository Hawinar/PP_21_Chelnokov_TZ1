using System.Collections;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] private Vector3 userDirection;
    [SerializeField] private float _speed;
    private void Start()
    {
        StartCoroutine(SelfDestroy());
    }
    private void Update()
    {
        transform.Translate(userDirection * _speed * Time.deltaTime);
    }

    IEnumerator SelfDestroy()
    {
        yield return new WaitForSeconds(10);
        Destroy(transform.gameObject);
    }
}
