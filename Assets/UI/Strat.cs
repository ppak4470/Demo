using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Strat : MonoBehaviour
{
    int sceneIndex;
    public void Scenario01_01()
    {
        SceneManager.LoadScene("Scenario01_01");
        Debug.Log("시나리오 1");
    }

    public void Scenario01_02()
    {
        SceneManager.LoadScene("Scenario01_02");
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
