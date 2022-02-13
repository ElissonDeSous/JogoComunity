using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    public bool inventarioOpen;
    public GameObject inventarioHud;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown("e"))
        {
              inventarioOpen = !inventarioOpen;
        }
        inventarioHud.SetActive(inventarioOpen);
    }
}
