using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePrefabMaterial : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Material[] materials;
    private int currentMat = 0;

    private void Start()
    {
        EventOnClick.buttonToggle += ToggleMaterial;
    }

    private void OnDestroy()
    {
        prefab.GetComponent<MeshRenderer>().sharedMaterial = materials[0];
    }


    public void ToggleMaterial()
    {
        currentMat += 1;
        currentMat %= materials.Length;
        
        Debug.Log("CurrentMat =>" + currentMat);
        
        prefab.GetComponent<MeshRenderer>().sharedMaterial = materials[currentMat];
    }
    
}
