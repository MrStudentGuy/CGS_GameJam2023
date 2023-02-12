using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acceptdeny : MonoBehaviour
{
    public GameManager gm;

    public AudioSource sound;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Accept()
    {
        Debug.Log("Accepted");
        sound.Play();
        gm.StoryNumInc();
        gm.pubRep += 25;
        gm.gRep -= 25;
    }
    
    public void Deny()
    {
        Debug.Log("Denied");
        sound.Play();
        gm.StoryNumInc();
        gm.pubRep -= 25;
        gm.gRep += 25;
    }
}
