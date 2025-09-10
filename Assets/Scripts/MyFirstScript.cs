using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    [SerializeField]
    private float speed;


    // Start is called before the first frame update
    void Start()
    {
        print("Test Start");
    }

    // Update is called once per frame
    void Update()
    {
        print(speed);
    }

    // onDestory is called once when the object is destoryed
    void OnDestroy()
    {
        print("Test Destroy");
    }
}
