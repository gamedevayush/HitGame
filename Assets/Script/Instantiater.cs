using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiater : MonoBehaviour
{
    public GameObject Pathway;
	int counter=2; 

    void Start()
	{
		
	}
    public void Generate()
    {
     GameObject g=Instantiate(Pathway);
	 g.transform.position=new Vector3(counter*40,0,0);	 
	 counter++;
    }
}
