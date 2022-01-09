using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalsPrefabs;
    public int animalIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)){
            Instantiate(animalsPrefabs[animalIndex], new Vector3(0, 0, 20), animalsPrefabs[animalIndex].transform.rotation);
        }
    }
}
