using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour
{
    public GameObject screen;
  public void Goback()
    {
        screen.SetActive(false);
    }
}
