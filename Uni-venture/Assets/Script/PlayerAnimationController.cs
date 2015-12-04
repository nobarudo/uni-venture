using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class PlayerAnimationController : MonoBehaviour {
    private Transform taget;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update () {
        bool isDownJump = Input.GetKey(KeyCode.Space);
        bool isDownUp = Input.GetKey("up");
        bool isDownLeft = Input.GetKey("left");
        bool isDownRight = Input.GetKey("right");
        bool isDownDown = Input.GetKey("down");

        animator.SetBool("DASH", isDownUp || isDownRight || isDownDown || isDownLeft);
        animator.SetBool("RIGHT_UP", isDownUp && isDownRight || isDownDown && isDownLeft);
        animator.SetBool("LEFT_UP", isDownUp && isDownLeft || isDownDown && isDownRight);
        animator.SetBool("JUMP", isDownJump);
	}
}
