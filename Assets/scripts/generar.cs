using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generar : MonoBehaviour
{
    public GameObject prefabenemy;
    float minposicion=-1.5f;
    float maxposicion = 1.5f;
    public float countspawn;
    public float concurrenttimecreation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        concurrenttimecreation = concurrenttimecreation + Time.deltaTime;
        if(concurrenttimecreation> countspawn)
        {
            Instantiate(prefabenemy, new Vector2(Random.Range(minposicion, maxposicion), transform.position.y),transform.rotation);
            concurrenttimecreation = 0;
        }
    }
}
