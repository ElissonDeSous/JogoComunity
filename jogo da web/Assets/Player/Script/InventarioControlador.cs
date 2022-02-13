using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "Item",menuName = "Inventario/Criar",order = 1 )]

public class InventarioControlador : ScriptableObject
{
    public Texture2D icone;
    public string nomeDoItem;
    public int quantidade;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
