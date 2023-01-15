using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Cube : MonoBehaviour
{
   
    public Renderer ren;
    public AudioMixer audioMixer;
    public string sendName;    

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
            audioMixer.SetFloat(sendName, 0f);            
            ren.material.color = Color.black;
           
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("spherePlayer"))
        {

            audioMixer.SetFloat(sendName, -80f);
            ren.material.color = Color.green;

        }
    }

    
   

}
