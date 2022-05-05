using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Main: MonoBehaviour
{
    public float speed = 15.0f;
    public Rigidbody rb;
    public Vector3 movement;
	public GameObject Obstacle;
	public GameObject GO;
 
 
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
		InvokeRepeating("InstantObstacle",1,1);
		GO.SetActive(false);
    }
	
	void OnTriggerEnter(Collider col)
	{
		if(col.tag=="Path")
		{
			this.GetComponent<Instantiater>().Generate();
		}
		if(col.tag=="obs")
		{
			 GO.SetActive(true);
		}
	}
	
	void OnTriggerExit(Collider col)
	{
		if(col.tag=="Path")
		{
			Destroy(col.gameObject);
		}
	}
	
    void Update()
    {
        movement = new Vector3(speed/8, 0,-Input.GetAxis("Horizontal"));
    }
	
    void FixedUpdate()
    {
        rb.velocity = movement * speed;
    }
	
	void InstantObstacle()
	{
		Vector3 pos= new Vector3(transform.position.x+40, 1, Random.Range(-4.3f, 3f));
		Instantiate(Obstacle, pos, Quaternion.identity);
	}
	
	public void Restart()
	{
		 Application.LoadLevel(Application.loadedLevel);
	}
 
 
}