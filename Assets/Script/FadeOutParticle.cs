using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutParticle : MonoBehaviour
{
    public ParticleSystem emit;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitToFade());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

 
    IEnumerator WaitToFade()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
