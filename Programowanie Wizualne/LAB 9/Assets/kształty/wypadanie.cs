using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wypadanie : MonoBehaviour
{


    public GameObject [] kulka;
    bool flaga = false;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerujKulki", 0.5f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Return))
        { 
            //GenerujKulki();
            CancelInvoke("GenerujKulki");
            flaga = true;
        }
        if (flaga)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Invoke("GenerujKulki", 0.5f);
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Invoke("wyrzuc0", 0.5f);
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Invoke("wyrzuc1", 0.5f);
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Invoke("wyrzuc2", 0.5f);
            }

            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                Invoke("wyrzuc3", 0.5f);
            }

            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                Invoke("wyrzuc4", 0.5f);
            }
        }
        
    }

    void wyrzuc0()
    {
        Instantiate(kulka[0], transform.position, Quaternion.identity);
    }

    void wyrzuc1()
    {
        Instantiate(kulka[1], transform.position, Quaternion.identity);
    }

    void wyrzuc2()
    {
        Instantiate(kulka[2], transform.position, Quaternion.identity);
    }

    void wyrzuc3()
    {
        Instantiate(kulka[3], transform.position, Quaternion.identity);
    }

    void wyrzuc4()
    {

        Instantiate(kulka[4], transform.position, Quaternion.identity);
    }


    void GenerujKulki()
    {
        int los = Random.Range(0, kulka.Length);
        Instantiate(kulka[los], transform.position, Quaternion.identity);
    }
    
}
