using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class spehere : MonoBehaviour
{
    private Renderer ren;
    public AudioSource aSource;
    //public AudioClip[] aClip;
    private int clipIndex = 0;
    private int randomN;
    public Transform trans;
    public Rigidbody rb;
    public float force = 10f;




    // Start is called before the first frame update
    void Start()
    {
        ren = GetComponent<Renderer>();
        rb = GetComponent<Rigidbody>();
        trans = GetComponent<Transform>();

        
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.A))
        {
            ren.material.color = Color.red;
            rb.velocity = new Vector3(-1, 0, 0) * force;

            //aSource[0].Play();

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            ren.material.color = Color.blue;
            rb.velocity = new Vector3(1, 0, 0) * force;
            //aSource[1].Play();

        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            ren.material.color = Color.cyan;
            rb.velocity = new Vector3(0, 0, 1) * force;
           

            // aSource[2].Play();

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            ren.material.color = Color.green;
            rb.velocity = new Vector3(0, 0, -1) * force;
            // aSource[3].Play();

        }
        if (Input.GetMouseButtonDown(0))
        {
            if (aSource.isPlaying && Input.GetMouseButtonDown(0))
            {
                aSource.Stop();                


            }

            ren.material.color = Color.gray;
                        
            aSource.Play();
            

        }

      

        




    }
}
