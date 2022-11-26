using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraImprove : MonoBehaviour
{
    public Camera camera1; 
    public Camera camera2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "land")
        {
            camera1.enabled = false;
            camera2.enabled = true;
        }
        
    }


    private void OnTriggerExit(Collider other)
    {
        //fpView.center = new Vector3(0, 1.15f, 2.92f);
        if (other.transform.tag == "land")
        {
            camera1.enabled = true;
            camera2.enabled = false;
        }
    }


}
