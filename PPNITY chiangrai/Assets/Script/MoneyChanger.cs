using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyChanger : MonoBehaviour
{
    public TMP_Text MoneyText;
    string outtext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        outtext = MainVarHolder.Money.ToString() + "$";
        MoneyText.text = outtext;
    }
}
