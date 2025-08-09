using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawntime;
    public float yposmin, yposmax;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnpipe());

    }
    IEnumerator spawnpipe ()
    {
        yield return new   WaitForSeconds  (spawntime);
        Instantiate(pipe, transform.position + Vector3.up * Random.Range(yposmin, yposmax), Quaternion.identity); 
        StartCoroutine(spawnpipe ());
    }
    // Update is called once per frame  
    void Update()
    {
        
    }
}
