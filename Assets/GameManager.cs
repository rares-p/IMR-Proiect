using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void GameEnded(bool win)
    {
        SceneManager.LoadScene(win ? "WonScene" : "LostScene");
    }
}
