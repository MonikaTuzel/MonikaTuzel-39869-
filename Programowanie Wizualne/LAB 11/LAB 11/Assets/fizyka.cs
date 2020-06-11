using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fizyka : MonoBehaviour
{
    Rigidbody fiz;
    float inputX, inputZ;
    public float speed;
    bool skok = false;
    bool strzal = false;
    public GameObject Naboj;
    public Transform pozNaboju;

    // Start is called before the first frame update

    void Awake()
    {
        fiz = GetComponent<Rigidbody>();
    }

    void Start()
    {
        //fiz.velocity = new Vector3(0, 0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump"))
        {
            skok = true;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            strzal = true;
        }
    }
        void FixedUpdate()
        {
            fiz.velocity = new Vector3(inputX*speed, fiz.velocity.y, inputZ*speed);
        
        if (skok == true)
            {
            Skok();
            skok = false;
            }

        if (strzal == true)
            {
                Strzal();
                strzal = false;
            }
        }

    void Skok()
    {
        fiz.AddForce(0, 200, 0);
    }
    void Strzal()
        {
            GameObject nowyNaboj = Instantiate(Naboj, pozNaboju.position, Quaternion.identity);
            nowyNaboj.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 30);
      
        }
    
}
