using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float BackgroundSpeed;
    public Renderer bR;

    // Update is called once per frame
    void Update()
    {
        bR.material.mainTextureOffset += new Vector2(Time.deltaTime * BackgroundSpeed , 0f);
    }
}