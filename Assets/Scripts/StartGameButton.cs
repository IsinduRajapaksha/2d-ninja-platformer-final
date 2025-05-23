using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    public int gameStartScene;

    // Call this to start the game
    public void StartGame()
    {
        SceneManager.LoadScene(gameStartScene);
    }

    // Call this to quit the game
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
        Application.Quit();
#elif UNITY_WEBGL
        SceneManager.LoadScene("QuitScene"); // Optional: load a "Thanks for playing" scene
#endif
    }
}
