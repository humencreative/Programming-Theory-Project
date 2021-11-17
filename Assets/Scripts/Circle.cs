using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Circle : Shape // INHERITANCE
{
    // ENCAPSULATION
    public float m_scale {
        get
        {
            return scale;
        }
        set
        {
            if(value >= 1 && value <= 3)
                scale = value;
            else
            {
                scale = 1;
                Debug.Log("Scale value must in 1...3");
            }
        }
    }
    void Start()
    {
        shape_name = "Circle";
    }
    
    protected override void ChangeScale() // POLYMORPHISM
    {
        m_scale = Random.Range(2,7);
        TransformScale();
    }
    
    private void OnMouseDown()
    {
        ChangeScale();
        DisplayText();
    }
}
