using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject ArrowPrefab;

    private float _minY = -2.9f;
    private float _maxY = 4.2f;

    private void Start()
    {
        StartCoroutine(StartSpawn());
    }
    IEnumerator StartSpawn()
    {
        yield return new WaitForSeconds(Random.Range(1.5f, 3f));

        Instantiate(ArrowPrefab, new Vector2(transform.position.x, Random.Range(_minY, _maxY)), Quaternion.identity);

        StartCoroutine(StartSpawn());
    }
}
