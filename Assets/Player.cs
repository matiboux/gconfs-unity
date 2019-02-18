using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    [SerializeField] private GameObject body;
    public GameObject projectilePrefab;
    public GameObject projectileSpawn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // The player looks where the user cursor points
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, 100))
            body.transform.LookAt(new Vector3(hit.point.x, body.transform.position.y, hit.point.z));

        // Shoot a projectile on Fire
        // (i) Quaternion.identity
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate a new object
            Instantiate(
                projectilePrefab, // The object to instantiate
                projectileSpawn.transform.position, // The position where to instantiate it
                Quaternion.identity // Identity Rotation (no rotation)
                );
        }
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
