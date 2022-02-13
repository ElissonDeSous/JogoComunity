using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public Rigidbody2D rig;
    public float vel;
    public float velV;
    void Start()
    {
        
    }

    
    void Update()
    {
        float move = Input.GetAxis("Horizontal")*vel;
        rig.velocity = new Vector2(move,0);
    
        float moveV = Input.GetAxis("Vertical")*velV;
        rig.velocity = new Vector2(0,moveV);
    }
}
