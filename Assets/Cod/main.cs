using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStarter : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Start");
        Debug.Log("Strat로 이동");
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