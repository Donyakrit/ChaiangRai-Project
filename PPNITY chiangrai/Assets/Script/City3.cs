using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City3 : MonoBehaviour
{
    bool isinside;
    public GameObject E;
    // Start is called before the first frame update
    void Start()
    {
        isinside = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isinside)
        {
            E.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                City3Run();
            }
        }
        else
        {
            E.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            isinside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isinside = false;
        }
    }

    void City3Run()
    {
        if (MainVarHolder.City3Power)
        {
            MainVarHolder.City3Power = false;
        }
        else
        {
            MainVarHolder.City3Power = true;
        }
    }
}
