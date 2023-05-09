using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeVFXColor : MonoBehaviour
{
    private ParticleSystem target;

    public float arrangeRange = 0.5f;

    private void Awake()
    {
        target = GetComponent<ParticleSystem>();
    }

    public void Call(Color color)
    {
        var main = target.main;
        main.startColor = color;
    }
}
