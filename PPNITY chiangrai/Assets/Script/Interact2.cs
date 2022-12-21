using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact2 : MonoBehaviour
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
                BuyWind();
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

    void BuyWind()
    {
        if (MainVarHolder.Money >= MainVarHolder.WindCost)
        {
            MainVarHolder.WindUnit += 1;
            MainVarHolder.Money -= MainVarHolder.WindCost;
        }
    }
}
