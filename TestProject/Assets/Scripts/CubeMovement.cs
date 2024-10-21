using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    float n = 0.001f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        n += (n > 0) ? (0.001f) : (-0.001f);
        if (Mathf.Abs(transform.position.x) > 10) n = -n;
        transform.position += new Vector3 (n, 0, 0);
    }
}
