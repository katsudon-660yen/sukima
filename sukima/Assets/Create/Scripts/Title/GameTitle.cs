using UnityEngine;
using UnityEngine.SceneManagement;


public class GameTitle : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    public void OnClickStartButton()
    {
        audioSource.PlayOneShot(sound1);
        //ここに遷移させるシーン名
        Invoke("Call", 0.5f);
    }

    public void Call()
    {
        SceneManager.LoadScene("Title_Scene");
    }
}