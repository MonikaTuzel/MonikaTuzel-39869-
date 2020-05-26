using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject[] znajdz;
    // Start is called before the first frame update
    void Start()
    {
        znajdz = GameObject.FindGameObjectsWithTag("kula");
        foreach(GameObject s in znajdz)
        {
            Destroy(s);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
