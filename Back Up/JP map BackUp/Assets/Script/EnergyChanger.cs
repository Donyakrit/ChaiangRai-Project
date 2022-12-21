using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnergyChanger : MonoBehaviour
{
    public TMP_Text EnergyText;
    string outtext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        outtext = MainVarHolder.Energy.ToString() + " / " + MainVarHolder.MaxEnergy.ToString();
        EnergyText.text = outtext;
    }
}
