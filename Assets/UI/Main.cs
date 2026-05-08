using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class Main : MonoBehaviour
{
    int sceneIndex;
    public void StartGame()
    {
        SceneManager.LoadScene(sceneIndex + 1);
        Debug.Log("시나리오 1");
    }

    public void ExitGame()
    {
        Debug.Log("게임 종료");
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false; // 에디터 전용
        #else
            Application.Quit(); // 빌드 전용
        #endif
    }
}
