using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_managment : MonoBehaviour
{

    public static cube_managment cube;

    public float AnglePerSecond;
    void Awake()
    {
        cube = this;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(AnglePerSecond*Time.deltaTime, 0, 0);
    }
}
