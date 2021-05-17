using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeTransparant : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject a = gameObject;
        Renderer b = a.GetComponent<Renderer>();
        Color col = b.material.color;
        const float alpha = 0.0f;
        col.a = alpha;
        b.material.color = col;
    }
}
