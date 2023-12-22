using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    void Transform Teleport_Point;

    private voidOnTriggerStay(Collider other)
    {
        other.transform.position = Teleport_Point.transform.position;
    }

    
}
