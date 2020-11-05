﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape 
{
    // Start is called before the first frame update
    Vector2 speed = new Vector2();

    public Shape(float _xspeed, float _yspeed)
    {
        speed = new Vector2(_xspeed, _yspeed);
    }

    public void MoveRight(Rigidbody2D myshape)
    {
        myshape.velocity = speed;

    }

    public void MoveLeft(Rigidbody2D myshape)
    {
        myshape.velocity = -speed;

    }


}
