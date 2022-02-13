using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayItem : MonoBehaviour
{
   public InventarioControlador item;
   public RawImage IconeItem;
   public Text quantidadeItem;
   public Text nomeDoItem;
    void Start()
    {
        quantidadeItem.text = "" +item.quantidade;
        IconeItem.texture = item.icone;
        nomeDoItem.text = ""+item.nomeDoItem;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
