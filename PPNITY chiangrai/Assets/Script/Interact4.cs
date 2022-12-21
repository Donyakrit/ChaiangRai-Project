using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact4 : MonoBehaviour
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
                BuyNuclear();
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

    void BuyNuclear()
    {
        if (MainVarHolder.Money >= MainVarHolder.NuclearCost)
        {
            MainVarHolder.NuclearUnit += 1;
            MainVarHolder.Money -= MainVarHolder.NuclearCost;
        }
    }
}
