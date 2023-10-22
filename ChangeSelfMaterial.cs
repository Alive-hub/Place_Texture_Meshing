using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSelfMaterial : MonoBehaviour
{
    [SerializeField] private Material[] materials;

    private MeshRenderer meshrenderer;
    private int currentMat = 0;

    private void Start()
    {
        meshrenderer = GetComponent<MeshRenderer>();
        EventOnClick.buttonToggle += ToggleMaterial;
    }

    public void ToggleMaterial()
    {
        if (meshrenderer)
        {
            currentMat += 1;
            currentMat %= materials.Length;
        
            Debug.Log("CurrentMat =>" + currentMat);
            meshrenderer.sharedMaterial = materials[currentMat % materials.Length];
        }
    }
}
