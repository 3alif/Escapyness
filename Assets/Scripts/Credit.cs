using UnityEngine;
using UnityEngine.SceneManagement;

public class Credit : MonoBehaviour
{
    public void LoadHome ()
    {
        Debug.Log("Done");
        SceneManager.LoadScene("Menu");
    }
}
