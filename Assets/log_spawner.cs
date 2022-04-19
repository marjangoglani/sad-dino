using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class log_spawner : MonoBehaviour
{

    public Transform SpawnPoint = null;
    public GameObject LogPrefab;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine("SpawnLog");
    }

    IEnumerator SpawnLog()
    {
        Instantiate(LogPrefab, SpawnPoint);
        yield return new WaitForSeconds(5f);
    }
}
