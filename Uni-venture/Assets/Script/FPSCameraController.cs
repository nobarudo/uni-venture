using UnityEngine;
using System.Collections;

public class FPSCameraController : MonoBehaviour {
    public Transform target;
    private Vector3 offset;
    private Vector3 Jump = new Vector3(0,2,0);

    void Start()
    {
        offset = GetComponent<Transform>().position - target.position;
    }

	// Update is called once per frame
	void Update () {
        GetComponent<Transform>().position = target.position + offset;
	}
}
