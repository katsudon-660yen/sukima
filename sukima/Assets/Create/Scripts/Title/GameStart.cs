using UnityEngine;
using UnityEngine.SceneManagement;


public class GameStart : MonoBehaviour
{
    public GameObject obj;

    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    public void OnClickStartButton()
    {
       
        Instantiate(obj, new Vector3(0.0f, 2.0f, 0.0f), Quaternion.identity);
        audioSource.PlayOneShot(sound1);
        //ここに遷移させるシーン名
        Invoke("Call", 0.5f);
    }

    public void Call()
    {
        SceneManager.LoadScene("Game_Scene");
    }
}
