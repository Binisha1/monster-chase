using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public GameObject dead;

    public void restart()

    {
        dead.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void home()
    {
        dead.SetActive(false);
        SceneManager.LoadScene("menu");
    }
    
}
