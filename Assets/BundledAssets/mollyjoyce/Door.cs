using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public bool Direction = true;
    private float Counter;
    private Vector3 Pos;

    private void Start()
    {
        Pos.x = 13.5f;
        Pos.y = .5f;
        Pos.z = -4f;
    }

    void Update()
    {

        if(Pos.x < 11.5)
        {
            Direction = true;
        } else if (Pos.x > 15.5)
        {
            Direction = false;
        }
        if(Direction == true)
        {
            Pos.x += .05f;
            transform.position = Pos;
        } else
        {
            Pos.x -= .05f;
            transform.position = Pos;
        }
    }
}
