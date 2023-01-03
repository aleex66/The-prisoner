using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheckSize : MonoBehaviour
{
    
    private float arml;
    void Start()
    {
        //arm.gameObject.transform.localScale.x;\
        arml = GetComponent<MeshRenderer>().bounds.extents.x;
        Debug.Log(arml);
    }
 
}
