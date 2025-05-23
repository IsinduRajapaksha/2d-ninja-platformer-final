//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class DeadEnd : MonoBehaviour
//{
//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        if (collision.CompareTag("Player"))
//        {
//#if UNITY_EDITOR
//            // Stop play mode in the editor
//            UnityEditor.EditorApplication.isPlaying = false;
//#else
//            // Quit the built application
//            Application.Quit();
//#endif
//        }
//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadEnd : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
