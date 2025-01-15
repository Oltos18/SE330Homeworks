using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Material redMaterial;
    public Material defaultMaterial;
    private MeshRenderer[] bodyPartsMeshRenderers;
 
    public void Awake()
    {
        bodyPartsMeshRenderers = GetComponentsInChildren<MeshRenderer>();
    }

    public void enemyCoroutineCaller()
    {
        StartCoroutine(damageMiddleCoroutine());
    }
    IEnumerator damageMiddleCoroutine()
    {
        yield return StartCoroutine(damageCoroutine(bodyPartsMeshRenderers));
    }

    IEnumerator damageCoroutine(MeshRenderer[] bodyPartsMeshRenderers)
    {
        foreach (MeshRenderer meshRenderer in bodyPartsMeshRenderers)
        {
            meshRenderer.material = redMaterial;
        }
        
        yield return new WaitForSeconds(0.15f);
        
        foreach (MeshRenderer meshRenderer in bodyPartsMeshRenderers)
        {
            meshRenderer.material = defaultMaterial;
        }
    }
}
