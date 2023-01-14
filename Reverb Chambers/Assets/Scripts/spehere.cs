using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class spehere : MonoBehaviour
{
    private Renderer ren;
    //rpublic AudioClip[] audioSource;
    public AudioSource [] aSource;


    // Start is called before the first frame update
    void Start()
    {
        ren = GetComponent<Renderer>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ren.material.color = Color.red;
            aSource[0].Play();

        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            ren.material.color = Color.blue;
            aSource[1].Play();

        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            ren.material.color = Color.cyan;
            aSource[2].Play();

        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            ren.material.color = Color.green;
            aSource[3].Play();

        }


    }
}
