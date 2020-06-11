using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public float pred;
    public GameObject[] paczka;
    void Start()
    {
        
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * pred;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * pred;

        transform.Translate(x, y, 0);

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pozycja = Input.mousePosition;
            pozycja.z = 15f;
            pozycja = Camera.main.ScreenToWorldPoint(pozycja);
            int los = Random.Range(0, paczka.Length);
            Instantiate(paczka[los], pozycja, Quaternion.identity);
        }
    }
}
