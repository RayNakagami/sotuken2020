using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public GameObject EventListner;
    // eventListnerScript script;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision C)
    {
        if (C.gameObject.name == "SD_unitychan")
        {
            EventListner.GetComponent<Event>().AddScore();
        }
        Debug.Log(C.gameObject.name);
        Debug.Log("A");
    }

}
