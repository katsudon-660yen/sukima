using UnityEngine;
using UnityEngine.SceneManagement;


public class GameStart : MonoBehaviour
{
    public void OnClickStartButton()
    {
        //ここに遷移させるシーン名
        SceneManager.LoadScene("Result_Scene");
    }
}
