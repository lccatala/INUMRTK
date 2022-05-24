using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManipulations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rotate45()
    {
        transform.Rotate(new Vector3(0, 45, 0));
    }

    public void Scale50()
    {
        transform.localScale += new Vector3((float)0.1, (float)0.1, (float)0.1);
    }

    public void Adelante()
    {
        transform.Translate(Vector3.forward);
    }

    public void Atras()
    {
        transform.Translate(Vector3.back);
    }
}
