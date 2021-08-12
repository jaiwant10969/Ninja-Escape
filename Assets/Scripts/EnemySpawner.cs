using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject stone;
    public float maxPos = 2.13f;
    public float delayTimer = 1f;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0) 
        {
            Vector3 stonePos = new Vector3(Random.Range(-2.13f, 2.13f), transform.position.y, transform.position.z);
            Instantiate(stone, stonePos, transform.rotation);
            timer = delayTimer;
        }
        
    }
}
