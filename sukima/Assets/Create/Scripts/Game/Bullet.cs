using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //[SerializeField]
    public float m_Drawtime = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        m_Drawtime = 1.5f;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right);

        if (hit.collider != null)
        {
            Debug.DrawRay(transform.position, hit.point, Color.green, 1.0f);

            if (hit.collider.gameObject.GetComponent<BoxCollider2D>())
            {

            }
        }
    }


    // Update is called once per frame
    void Update()
    {


        m_Drawtime -= Time.unscaledDeltaTime;

        if (m_Drawtime <= 0)
        {
            Time.timeScale = 1;
            Destroy(this.gameObject);
        }
    } 
}
