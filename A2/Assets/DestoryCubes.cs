using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryCubes : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Cube")
        {
            Destroy(col.gameObject);
        }
    }
}
