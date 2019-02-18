using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody rb;
    private GameObject player;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player"); // Find the Player GameObject
    }

    // Update is called once per frame
    void Update()
    {
        // Look at the player
        transform.LookAt(player.transform);

        // Move towards the player
        Vector3 curV = rb.velocity;
        rb.velocity = new Vector3(
            transform.forward.x * speed, // Move forward
            curV.y, //
            transform.forward.z * speed); // Move forward
    }
}
