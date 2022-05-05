using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public int dtime;
    void OnEnable()
    {
        Destroy(gameObject,dtime);
    }

}
