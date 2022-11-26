using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class harrypotter : MonoBehaviour
{

    public Transform spawnPoint;

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
        if (other.tag == "transformWall")
        {
            gameObject.transform.position = new Vector3(17.66f, 0f, 9.453f);
            gameObject.transform.rotation = spawnPoint.rotation;
        }

    }


}
