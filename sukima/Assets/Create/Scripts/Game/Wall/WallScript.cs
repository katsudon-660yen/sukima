using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum MOVE_TYPE
{
    SIN,
    SIN_MINUS
};

public class WallScript : MonoBehaviour
{
    [SerializeField]
    float term = 0.0f;     // 周期

    [SerializeField]
    float amplitude = 0.0f;    // 振幅

    float time;    // 経過時間

    [SerializeField]
    MOVE_TYPE moveType = MOVE_TYPE.SIN;

    Vector3 basePosition;

    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;

        basePosition = gameObject.GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 deltaPosition = new Vector3(0.0f,0.0f,0.0f);
        switch(moveType)
        {
            case MOVE_TYPE.SIN:
                deltaPosition = new Vector3(0.0f, amplitude * Mathf.Sin(2 * Mathf.PI * time / term), 0.0f);
                break;
            case MOVE_TYPE.SIN_MINUS:
                deltaPosition = new Vector3(0.0f, -amplitude * Mathf.Sin(2 * Mathf.PI * time / term), 0.0f);
                break;
            default:
                break;
        }
        gameObject.GetComponent<Transform>().position = basePosition + deltaPosition;

        time += Time.deltaTime;

    }
}
