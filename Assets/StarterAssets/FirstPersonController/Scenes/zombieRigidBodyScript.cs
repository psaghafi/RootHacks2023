using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieRigidBodyScript : MonoBehaviour
{
    public GameObject Player;
    public float Speed;

    public bool ActiveZ = false;
    public Vector3 dist;
    public float a;
    
    //public Transform GameObject;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("GameObject");
        Speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        dist = Player.transform.position - transform.position;
        print("Distance: " + dist.magnitude);
        a = dist.magnitude;
        //Vector3 direction = GameObject.position - transform.position;
        //Debug.Log(direction);
        if (true)
        {
            Vector3 direction = (Player.transform.position - transform.position).normalized;
            this.transform.Translate(direction * Speed * Time.deltaTime);
        }
    }
}
