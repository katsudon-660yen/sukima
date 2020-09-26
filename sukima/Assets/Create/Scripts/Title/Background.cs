using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private Vector3 value;
    public Vector2 m_speed;
    void Update()
    {
        var spriteRenderer = GetComponent<SpriteRenderer>();
        var material = spriteRenderer.material;
        material.mainTextureOffset += m_speed * Time.deltaTime;
    }
}
