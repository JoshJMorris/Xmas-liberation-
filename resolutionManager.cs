using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resolutionManager : MonoBehaviour
{
    public int width;
    public int height;

    public void setWidth(int newWidth)
    {
        width = newWidth;


    }

    public void setHeight(int newHeight)
    {
        height = newHeight;


    }

    public void setRes()
    {
        Screen.SetResolution(width, height, false);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
