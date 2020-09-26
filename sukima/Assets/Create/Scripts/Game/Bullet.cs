using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float m_Drawtime = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right);

        if (hit.collider != null)
        {
            Debug.DrawRay(transform.position, hit.point, Color.green, 0.1f);
            if (hit.collider.gameObject.GetComponent<Goal>())
            {
                Goal a = hit.collider.gameObject.GetComponent<Goal>();
                StartCoroutine(Goal(a));
            }
        }
    }

    IEnumerator Goal(Goal a)
    {
        Time.timeScale = 0;
        yield return new WaitForSecondsRealtime(m_Drawtime);

        Time.timeScale = 1;
        Destroy(this.gameObject);
        a.SceneChange();
        yield break;
    }
}
