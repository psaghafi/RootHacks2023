using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject zombiePrefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.CapsLock))
        {
            Instantiate(zombiePrefab,transform.position, Quaternion.identity );
        }
    }
}
