using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit: MonoBehaviour
{
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
