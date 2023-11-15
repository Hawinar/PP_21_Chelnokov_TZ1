using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _object;

    [SerializeField] private float _timeBetweenSpawn;
    private List<Vector2> _spawnPoint;
    private float _time;
    void Update()
    {
        if (Time.time > _time)
        {
            Spawn(_object);

            _time = Time.time + _timeBetweenSpawn;
        }
    }
    private void Spawn(GameObject gameObject)
    {
        _spawnPoint = new List<Vector2>() { new Vector2(-10, Random.Range(-5, 5)), new Vector2(10, Random.Range(-5, 5)), new Vector2(Random.Range(-10, 10), -6), new Vector2(Random.Range(-10, 10), 6) };
        Instantiate(gameObject, _spawnPoint[Random.Range(0,4)], new Quaternion(0, 0, 0, 0));
    }
}
