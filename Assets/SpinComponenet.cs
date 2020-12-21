using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinComponenet : MonoBehaviour
{
    private bool printedMessage = false;
    private Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
        Debug.Log(myTransform);
        
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.Rotate(.1f, 0f, 0f);
        if (!printedMessage)
        {
            Debug.Log("Hello from Update");
            printedMessage = true;
        }

    }
}
