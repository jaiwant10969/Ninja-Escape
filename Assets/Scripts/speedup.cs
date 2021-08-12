using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedup : MonoBehaviour
{
    float currentSpeed = 0f;
    float maxSpeed = 10f;
    public float movementSpeed = 5.0f;
    public GameObject player;
    private float screenCenterX;
    // New variables :
    public float accelerationTime = 60;
    private float minSpeed;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        screenCenterX = Screen.width * 0.5f;
        minSpeed = currentSpeed;
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentSpeed = Mathf.SmoothStep(minSpeed, maxSpeed, time / accelerationTime);
        transform.position -= transform.forward * currentSpeed * Time.deltaTime;
        time += Time.deltaTime;
    }
}
