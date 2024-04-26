using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string sampleMsg;

    private void Awake()
    {
        Debug.Log("Awake!");
        Debug.Log(sampleMsg);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start!");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
        Debug.Log(sampleMsg);
    }
}
