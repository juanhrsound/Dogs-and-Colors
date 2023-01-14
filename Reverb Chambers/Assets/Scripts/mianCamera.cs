using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mianCamera : MonoBehaviour
{
    
    public Transform target;
    public float number = 10f;



    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(target);
        
        
    }
}
