using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceBar : MonoBehaviour {
    // This is mainly to see the space bar in the video, nothing else. 
    public Material spaceBarMaterial;
    private Material defaultMaterial;
    private Renderer renderer;

    void Awake() {
        renderer = GetComponent<Renderer>();
    }
    
    void Start() {
        defaultMaterial = renderer.material;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            renderer.material = spaceBarMaterial;
        }
        if (Input.GetKeyUp(KeyCode.Space)) {
            renderer.material = defaultMaterial;
        }
        
    }
}
