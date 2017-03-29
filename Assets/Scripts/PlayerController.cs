using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public GameObject prefab;

    void Start()
    {
    
    }

    // Update is called once per frame
    void Update () {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        if (Input.GetMouseButtonDown(0))
            Shoot();
    }

    void Shoot () {
        GameObject gameObject = Instantiate(prefab, transform.position + transform.rotation * new Vector3(0,0.5f,1) * 2 , transform.rotation);

        gameObject.GetComponent<Rigidbody>().AddForce(transform.rotation * Vector3.forward * 5000);
    }
}