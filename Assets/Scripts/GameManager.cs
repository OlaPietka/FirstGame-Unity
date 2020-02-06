using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameOver = false;
    public float restartDelay = 1f;
    public GameObject compliteLvlUI;

    public void EndGame()
    {
        if (gameOver == false)
        {
            gameOver = true;

            Invoke("Restart", restartDelay);
        }
    }
    public void CompliteLvl()
    {
        compliteLvlUI.SetActive(true);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
