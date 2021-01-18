using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public GameObject EventListner;
    public GameObject semi;

    bool isSemi;
    // eventListnerScript script;

    // Start is called before the first frame update
    void Start()
    {
        isSemi = true;
        semi.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision C)
    {
        if (C.gameObject.name == "SD_unitychan")
        {
            if (isSemi)
            {
                EventListner.GetComponent<Event>().AddScore();
                isSemi = false;
                semi.SetActive(false);
            }
        }
    }

    public void SetSemi()
    {
        if (!isSemi)
        {
            isSemi = true;
            semi.SetActive(true);
        }
    }

}
