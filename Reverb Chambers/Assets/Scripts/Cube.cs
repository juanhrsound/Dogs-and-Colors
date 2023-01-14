using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : MonoBehaviour
{
   
    public Renderer ren;

    // Start is called before the first frame update
    void Start()
    {
        ren = GetComponent<Renderer>();
     
        
    }

    // Update is called once per frame
    void Update()
    {
              


        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("spherePlayer"))
        {
            if (ren.material.color == Color.black)
            {
                ren.material.color = Color.red;
            }
        }
    }
}
