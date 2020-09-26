using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Bullet m_Bullet;

    [SerializeField, Space(20)]
    private float m_FireRate = 0.5f;
    private float m_FireCD;

    AudioSource _audioSource;

    void Start()
    {
        m_FireCD = 0;
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(m_FireCD > 0)
        {
            m_FireCD -= Time.deltaTime;
        }
        if(Input.GetKeyDown(KeyCode.Space) && m_FireCD <= 0)
        {
            Bullet blt = Instantiate(m_Bullet);
            blt.gameObject.transform.position = transform.position;
            _audioSource.PlayOneShot(_audioSource.clip);
            m_FireCD = m_FireRate;
            //Time.timeScale = 0;
        }
    }
}
