using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBackgroundMovement : MonoBehaviour
{
    public float velocity = 0.1f;
    public Renderer quad;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // the amount to move
        Vector2 offset = new Vector2(velocity * Time.deltaTime, 0);

        //make the move
        quad.material.mainTextureOffset += offset;
    }
}
