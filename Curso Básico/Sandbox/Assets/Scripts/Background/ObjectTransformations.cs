using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTransformations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // direções
        //transform.Translate( new Vector3(0.1f, 0, 0));

        // rotação
        //transform.Rotate( new Vector3(0,0,0.1f) );

        // escala
        transform.localScale += new Vector3(0.1f, 0.1f, 0);

    }
}
