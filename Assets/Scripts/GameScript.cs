using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    [SerializeField] private List<GameObject> targets;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 10; i++) {
            Vector3 pos = new Vector3(Random.Range(-10.0f, 10), Random.Range(0.0f, 10.0f), Random.Range(-10.0f, 10.0f));
            Instantiate(targets[Random.Range(0, 4)], pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
