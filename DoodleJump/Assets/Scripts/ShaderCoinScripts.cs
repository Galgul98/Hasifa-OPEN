using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderCoinScripts : MonoBehaviour
{
    bool power;
    MeshRenderer meshRenderer;


    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }


    void Update()
    {
        if (power)
        {
            meshRenderer.material.SetFloat("Vector1_de2c17c5a85c4206a0d8ce480ab2d7ff", meshRenderer.material.GetFloat
                ("Vector1_de2c17c5a85c4206a0d8ce480ab2d7ff") + 0.5f);
            if (meshRenderer.material.GetFloat("Vector1_de2c17c5a85c4206a0d8ce480ab2d7ff") >= 5f)
                power = false;
        }
        else
        {
            meshRenderer.material.SetFloat("Vector1_de2c17c5a85c4206a0d8ce480ab2d7ff", meshRenderer.material.GetFloat
                           ("Vector1_de2c17c5a85c4206a0d8ce480ab2d7ff") - 0.5f);
            if (meshRenderer.material.GetFloat("Vector1_de2c17c5a85c4206a0d8ce480ab2d7ff") <= 1f)
                power = true;
        }
    }
}
