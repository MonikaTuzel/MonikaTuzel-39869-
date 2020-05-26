using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int a = 5;
    // Start is called before the first frame update
    void Start()
    {
        do
        {
            print("Monika");
            a--;

        } while (a > 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
