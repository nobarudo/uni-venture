using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
    public int  SPEED = 10;
    public GameController gameController;
    public GameObject player;
    private bool CubeCollision;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        int Rand = Random.Range(0, 15);

        if (Rand <= 4 && CubeCollision == true)
        {
            transform.Rotate(0,90,0);
        } else if (Rand >= 5 && CubeCollision == true)
        {
            transform.Rotate(0, -90, 0);
        }
        else if (Rand >= 10 && CubeCollision == true)
        {
            transform.Rotate(0, 180, 0);
        } else { transform.position += transform.forward * (0.06f * SPEED); }

        CubeCollision = false;
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {
            gameController.GameOver();
            Debug.Log("damge");
        }

        if (collision.gameObject.CompareTag("Cube"))
        {
            transform.position -= transform.forward * (0.07f * SPEED);
            CubeCollision = true;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            transform.position -= transform.forward * (1.0f);
            transform.Rotate(0, 180, 0);
        }
    }
}
