using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text scoreLabel;
    public GameObject GameClearLabel;
    public GameObject unityChan;
    public GameObject gameOverText;
    private bool gameOver = false;
	
	void Update () {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreLabel.text = count.ToString();

        if (count == 0)
        {
            GameClearLabel.SetActive(true);
            Application.LoadLevel("Stage01");
        }
        if (gameOver)
        {
            gameOverText.SetActive(true);
            if (Input.GetKey(KeyCode.Space))
            {
                Application.LoadLevel("title");
            }
        }
	}

    public void GameOver ()
    {
        gameOver = true;
        Destroy(unityChan);
    }
}
