using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyHint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyHintInfo());
    }

    IEnumerator DestroyHintInfo()
    {
        yield return new WaitForSeconds(25);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
