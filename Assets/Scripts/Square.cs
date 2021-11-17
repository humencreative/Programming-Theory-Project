using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    protected float m_scale
    {
        get
        {
            return scale;
        }
    }

    protected override void ChangeScale()
    {
        base.ChangeScale();
        TransformScale();
    }

    private void OnMouseDown()
    {
        ChangeScale();
        DisplayText();
    }
}
