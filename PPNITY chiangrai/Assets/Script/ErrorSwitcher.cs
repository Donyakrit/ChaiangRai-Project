using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorSwitcher : MonoBehaviour
{
    public GameObject AllError;
    public GameObject ErrorCause;
    public GameObject BlueLight;
    public GameObject RedLight;
    bool onetime;
    float currenttime;
    // Start is called before the first frame update
    void Start()
    {
        AllError.SetActive(false);
        onetime = true;
        ErrorCause.SetActive(false);
        currenttime = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(onetime && MainVarHolder.City1Power && MainVarHolder.City2Power && MainVarHolder.City3Power && MainVarHolder.City4Power && MainVarHolder.City5Power)
        {
            MainVarHolder.MainPower = false;
            AllError.SetActive(true);
            BlueLight.SetActive(false);
            RedLight.SetActive(true);
            onetime = false;
            FiveCheckChange();
        }

        if(!onetime)
        {
            currenttime -= Time.deltaTime;
        }

        if(currenttime <= 0)
        {
            ErrorCause.SetActive(true);
            AllError.SetActive(false);
        }
    }

    void FiveCheckChange()
    {
        currenttime = 2;
    }
}
