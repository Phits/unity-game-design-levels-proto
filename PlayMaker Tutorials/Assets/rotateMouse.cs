using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateMouse : MonoBehaviour {

	public float horizontalSpeed = 2.0F;
	public float m_Speed = 5.0F;
	Rigidbody m_Rigidbody;
    // public float verticalSpeed = 2.0F;

	// Use this for initialization
	void Start () {
		m_Rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

	    float h = horizontalSpeed * Input.GetAxis("Mouse X");
        // float v = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(0, h, 0);
		m_Rigidbody.velocity = transform.forward * m_Speed;
		
	}
}
