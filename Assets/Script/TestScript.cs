using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi!");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 20 * Time.deltaTime, 0);
    }
}
