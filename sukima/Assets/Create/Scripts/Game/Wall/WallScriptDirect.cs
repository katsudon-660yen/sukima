using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScriptDirect : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;

    [SerializeField]
    float limitTop;

    [SerializeField]
    float limitBottom;

    [SerializeField]
    bool isUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = gameObject.GetComponent<Transform>().position;

        if (isUp)
        {
            position.y += moveSpeed * Time.deltaTime;
        }
        else
        {
            position.y += -moveSpeed * Time.deltaTime;
        }

        gameObject.GetComponent<Transform>().position = position;

        if (position.y < limitBottom) 
        {
            isUp = true;
        }
        else if(position.y > limitTop)
        {
            isUp = false;
        }
    }

    public void SetLimitTop(float limit)
    {
        limitTop = limit;
    }

    public void SetLimitBottom(float limit)
    {
        limitBottom = limit;
    }

    public void SetSpeed(float speed)
    {
        moveSpeed = speed;
    }
}
