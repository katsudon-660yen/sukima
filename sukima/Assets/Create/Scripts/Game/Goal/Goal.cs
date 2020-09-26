using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    [SerializeField]
    private string _nextSceneName;

    public void SceneChange()
    {
        if(_nextSceneName == "Result_Scene")
        {
            Destroy(GameObject.Find("GameBGM"));
        }
        SceneManager.LoadScene(_nextSceneName);
    }
}
