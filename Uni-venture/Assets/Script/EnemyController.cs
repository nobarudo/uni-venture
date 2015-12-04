using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
    public int  SPEED = 10;
    public GameController gameController;
    public GameObject player;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        int Rand = Random.Range(0, 200);

        if (Rand <= 50)
        {
            transform.Rotate(0,30,0);
        } else if (Rand > 50 && Rand <= 100)
        {
            transform.Rotate(0, -30, 0);
        }

        if (Rand >= 150)
        {
            transform.LookAt(player.transform);
            Debug.Log("Tracking");
        }

        if (Rand == 101)
        {
            transform.Rotate(0, 90, 0);
        }

        transform.position += transform.forward * (0.06f * SPEED);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {
            gameController.GameOver();
            Debug.Log("damge");
        }
    }
}
