using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float min;
    public float max;
    public float delay;
    private float counter = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if(counter >= delay)
        {
            counter = 0f;
            for(int i = 0; i < 5; i++)
            {
                float x = Random.Range(min, max);
                float z = Random.Range(min, max);
                Instantiate(enemyPrefab, new Vector3(x, 0f, z), Quaternion.identity);
            }
        }
    }
}
