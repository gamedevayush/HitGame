using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkhit : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        if(col.tag=="obs")
		{
			Destroy(col.gameObject);
			Destroy(gameObject);
		}
	}
}
