using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    bool endedUp = false;
    public float delay = 2f;
    public GameObject completionUI;

    public void GameOver ()
    {
        if (endedUp == false)
        {
            endedUp = true;
            Debug.Log("It's Over");
            Invoke("Restart", delay);
        }
    }

    public void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Completion ()
    {
        completionUI.SetActive(true);
    }

    public void GoHome ()
    {
        SceneManager.LoadScene("Menu");
    }
}
