using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    Camera mainCamera;//メインカメラ
    Camera highCamera;//サブのカメラです
    void Start()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        highCamera = GameObject.Find("HighCamera").GetComponent<Camera>();

        highCamera.enabled = false;

    }

    void Update()
    {
        // Spaceキーで切り替え
        if (Input.GetKeyDown("c"))
        {
            if (mainCamera.enabled)
            {
                mainCamera.enabled = false;
                highCamera.enabled = true;
            }
            else
            {
                mainCamera.enabled = true;
                highCamera.enabled = false;
            }
        }
    }
}
