using UnityEngine;
using System.Collections;

public class PlatyerController : MonoBehaviour {
    public int SPEED = 1;
    public const int DASH = 5;
    Vector3 right = new Vector3(600, 0, 0);
    Vector3 left = new Vector3(-600, 0, 0);
    Vector3 Up = new Vector3(0, 0, 600);
    Vector3 Down = new Vector3(0, 0, -600);

    void Update () {
        SPEED = 4;
        bool isDownUp = Input.GetKey("up");
        bool isDownLeft = Input.GetKey("left");
        bool isDownRight = Input.GetKey("right");
        bool isDownDown = Input.GetKey("down");

        if (isDownRight)
        {
            transform.LookAt(right);
            transform.position += transform.forward * (0.03f * SPEED);
        }
        if (isDownLeft)
        {
            transform.LookAt(left);
            transform.position += transform.forward * (0.03f * SPEED);
        }
        if (isDownUp)
        {
            transform.LookAt(Up);
            transform.position += transform.forward * (0.03f * SPEED);
        }
        if (isDownDown)
        {
            transform.LookAt(Down);
            transform.position += transform.forward * (0.03f * SPEED);
        }
    }
}
