using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomAsteroidSpawner : MonoBehaviour
{
    Transform bottomSpawnerTrans;
    int randomX;
    float yPos = -5.5f;
    // Start is called before the first frame update
    void Start()
    {
        bottomSpawnerTrans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        randomX = Random.Range(-9, 9);
        bottomSpawnerTrans.transform.position = new Vector2(randomX, yPos);
    }
}
