using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour
{
    bool notCollide = true;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (notCollide)
        {
            transform.position = player.transform.position + new Vector3(0.5f,1f,-2f);
        }

        
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "land")
    //    {
    //        notCollide = false;
    //    }
        
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.tag == "land")
    //    {
    //        notCollide = true;
    //    }
    //}
}
