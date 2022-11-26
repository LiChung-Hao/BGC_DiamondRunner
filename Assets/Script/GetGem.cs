using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGem : MonoBehaviour
{
    public AudioClip getGem;
    public GameObject paricle;
    public ParticleSystem emit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter()
    {
        GemTotal.gemNum += 1;
        GetComponent<AudioSource>().PlayOneShot(getGem);
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<CapsuleCollider>().enabled = false;
        paricle.SetActive(true);
        Destroy(gameObject, 5f);
        // This splits the particle off so it doesn't get deleted with the parent
        emit.transform.parent = null;
        // this stops the particle from creating more bits
        //emit.Stop();
        Debug.Log(GemTotal.gemNum);
    }


}
