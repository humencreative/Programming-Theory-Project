using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Shape : MonoBehaviour
{
    [SerializeField]
    protected Text shapeInfo;
    protected string shape_name;
    protected float scale;
    // Start is called before the first frame update
    void Start()
    {
        shape_name = "Unkown";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // ABSTRACTION
    public void DisplayText()
    {
        shapeInfo.text = $"Figure: {shape_name}, scale: {scale}";
    }

    protected virtual void ChangeScale()
    {
        scale = Random.Range(1,5);
    }

    
    protected void TransformScale()
    {
        gameObject.transform.localScale = new Vector3(scale, scale, scale);
    }
}
