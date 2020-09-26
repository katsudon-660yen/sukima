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

    void Start()
    {
        m_FireCD = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(m_FireCD > 0)
        {
            m_FireCD -= Time.deltaTime;
        }
        if(Input.GetKeyDown(KeyCode.Space) && m_FireCD == 0)
        {
            Bullet blt = Instantiate(m_Bullet);
            blt.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            m_FireCD = m_FireRate;
            Time.timeScale = 0;
        }
    }
}
