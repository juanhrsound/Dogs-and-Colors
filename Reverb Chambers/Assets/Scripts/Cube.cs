using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Cube : MonoBehaviour
{
   
    public Renderer ren;
    public AudioMixer audioMixer;
    public AudioMixerGroup church;

    // Start is called before the first frame update
    void Start()
    {
        ren = GetComponent<Renderer>();
        audioMixer = GetComponent<AudioMixer>();
     
        
    }

    // Update is called once per frame
    void Update()
    {
              


        
    }
   

    private void OnTriggerStay(Collider other)
    {
        
        if(other.CompareTag("spherePlayer"))
        {
            if (ren.material.color == Color.black)
            {
                ren.material.color = Color.red;
            } else
            
            {
                SetSFXLvL(4f);
                ren.material.color = Color.black;
            }
        }
    }

    public void SetSFXLvL(float sfxLvl)
    {
        church.audioMixer.SetFloat("churchVol", sfxLvl);
    }

}
