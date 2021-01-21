using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveup : MonoBehaviour
{
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = this.gameObject.transform.position;
        // Debug.Log("A");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) pos.x += 0.1f;
        if (Input.GetKey(KeyCode.LeftArrow)) pos.x -= 0.1f;
        if (Input.GetKey(KeyCode.UpArrow)) pos.z += 0.1f;
        if (Input.GetKey(KeyCode.DownArrow)) pos.z -= 0.1f;
        this.gameObject.transform.position = this.pos;
        this.gameObject.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        // Debug.Log(this.gameObject.transform.rotation);
    }
}
