using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerCanvasSwitcher : MonoBehaviour
{
    public GameObject MainPower;
    public GameObject City1;
    public GameObject City2;
    public GameObject City3;
    public GameObject City4;
    public GameObject City5;
    public GameObject Bluelight;
    public GameObject Redlight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MainVarHolder.MainPower)
        {
            MainPower.SetActive(true);
            Bluelight.SetActive(true);
            Redlight.SetActive(false);
        }
        else
        {
            MainPower.SetActive(false);
            Bluelight.SetActive(false);
            Redlight.SetActive(true);
        }

        if (MainVarHolder.City1Power && MainVarHolder.MainPower)
        {
            City1.SetActive(true);
        }
        else
        {
            City1.SetActive(false);
        }

        if (MainVarHolder.City2Power && MainVarHolder.MainPower)
        {
            City2.SetActive(true);
        }
        else
        {
            City2.SetActive(false);
        }

        if (MainVarHolder.City3Power && MainVarHolder.MainPower)
        {
            City3.SetActive(true);
        }
        else
        {
            City3.SetActive(false);
        }

        if (MainVarHolder.City4Power && MainVarHolder.MainPower)
        {
            City4.SetActive(true);
        }
        else
        {
            City4.SetActive(false);
        }

        if (MainVarHolder.City5Power && MainVarHolder.MainPower)
        {
            City5.SetActive(true);
        }
        else
        {
            City5.SetActive(false);
        }
    }
}
