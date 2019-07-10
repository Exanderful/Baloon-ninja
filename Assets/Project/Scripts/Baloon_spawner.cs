using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baloon_spawner : MonoBehaviour {

    public float SpawnTimer, BaloonMinX, BaloonMaxX, BaloonY;
    public GameObject[] Baloons;
    public Timer Timer;

    void Start () {
        InvokeRepeating("CreateBaloon", SpawnTimer, SpawnTimer);
    }

    private void CreateBaloon()
    {
        if (Timer.seconds > 0)
        {
            GameObject newBaloon = Instantiate(Baloons[Random.Range(0, Baloons.Length)]);
            newBaloon.transform.position = new Vector2(Random.Range(BaloonMinX, BaloonMaxX), BaloonY);
        }
    }
}
