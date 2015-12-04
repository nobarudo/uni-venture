using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
    public int  SPEED = 10;
    public GameController gameController;
    public GameObject gamemaster;
    public GameObject player;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        int Rand = Random.Range(0, 200);

        if (Rand <= 10)
        {
            transform.Rotate(new Vector3(0, 1, 0), 30);
        } else if (Rand > 10 && Rand <= 20)
        {
            transform.Rotate(new Vector3(0, 1, 0), -30);
        }

        if (Rand == 100)
        {
            transform.Rotate(new Vector3(0, 1, 0), 90);
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
