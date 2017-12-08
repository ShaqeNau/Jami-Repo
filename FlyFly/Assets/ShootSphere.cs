using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSphere : MonoBehaviour
{

    public GameObject sphere;
    SteamVR_Controller contr;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("fire");
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject go = new GameObject();
        go = Instantiate(sphere, transform.position, transform.rotation);
        go.GetComponent<Rigidbody>().AddForce(transform.forward, ForceMode.Impulse);
        Destroy(go, 10f);
    }
}
