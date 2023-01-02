using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scores;

    // Update is called once per frame
    void Update()
    {
        scores.text = player.position.x.ToString("0");
    }
}
