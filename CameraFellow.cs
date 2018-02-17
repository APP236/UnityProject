using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFellow : MonoBehaviour {
    public Transform characterTarget;
    Camera MyCamera;
    public float movSpeed = 0.03f;

    
	// Use this for initialization
	void Start () {
        MyCamera = GetComponent<Camera>();
		
	}
	
	// Update is called once per frame
	void Update () {
		MyCamera.orthographicSize=(Screen.height/0.618f)/4f;
        if (characterTarget)
	{
            
            transform.position=Vector3.Lerp(transform.position,characterTarget.position,movSpeed)+new Vector3(0,0,-10);
	}

	}
}
