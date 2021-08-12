using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ninjacontroller : MonoBehaviour
{
    public float ninjaspeed;
    public float maxPos = 2.2f;

    Vector3 position;
    public UIManager ui;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //ui = GetComponent<UIManager> ();
        position.x += Input.GetAxis ("Horizontal") * ninjaspeed * Time.deltaTime;

        position.x = Mathf.Clamp (position.x, -2f, 2.2f);

        transform.position = position;
    }
    void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.tag == "Enemy Stone")
        {
            Destroy(gameObject);
            ui.gameOverActivated();
        }
    }
}
