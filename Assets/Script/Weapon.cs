using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 100f;




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            instBulletRigidbody.AddForce(-Vector3.left * speed);
        }
    }
}