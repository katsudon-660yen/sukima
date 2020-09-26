using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{
    [SerializeField]
    float speed;

    [SerializeField]
    float amplitude;

    [SerializeField]
    GameObject Up;

    [SerializeField]
    GameObject Down;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 posUp = Up.GetComponent<Transform>().position;
        Vector3 posDown = Down.GetComponent<Transform>().position;

        Up.GetComponent<WallScriptDirect>().SetSpeed(speed);
        Down.GetComponent<WallScriptDirect>().SetSpeed(speed);

        Up.GetComponent<WallScriptDirect>().SetLimitTop(posUp.y + amplitude);
        Up.GetComponent<WallScriptDirect>().SetLimitBottom(posUp.y);
        Down.GetComponent<WallScriptDirect>().SetLimitBottom(posDown.y - amplitude);
        Down.GetComponent<WallScriptDirect>().SetLimitTop(posDown.y);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
