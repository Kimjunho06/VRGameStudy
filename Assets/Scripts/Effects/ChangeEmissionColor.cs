using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEmissionColor : MonoBehaviour
{

    private Renderer target;

    public float emissionIntensity = 5f;

    private void Awake()
    {
        target = GetComponent<Renderer>();    
    }

    public void Call(Color color)
    {

        target.material.SetColor("_EmissionColor", color * emissionIntensity);
    }
}
