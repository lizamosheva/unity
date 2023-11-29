using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public int health = 10;
    public float speed = 1.2f;
    public int lvl = 1;

    // Start is called before the first frame update
    void Start()
    {
        health += lvl;
        print("Çהמנמגüו: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
