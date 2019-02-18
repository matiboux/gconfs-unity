using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Update is called when physics are updated
    void FixedUpdate()
    {
        // Input.GetAxis(): Get Axis value
        // Time.deltaTime: Time since last frame
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        // Move the object
        transform.Translate(new Vector3(horizontal, 0f, vertical));
    }
}
