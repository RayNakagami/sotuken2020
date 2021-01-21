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
        // Debug.Log("s");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionStay(Collision C)
    {
        if (C.gameObject.name == "SD_unitychan")
        {
            if (isSemi)
            {
                EventListner.GetComponent<Event>().AddScore();
                isSemi = false;
                semi.SetActive(false);
                Debug.Log(semi.gameObject.name);
            }
        }
        // Debug.Log(C.gameObject.name);
        // Debug.Log(semi.gameObject.name);
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
