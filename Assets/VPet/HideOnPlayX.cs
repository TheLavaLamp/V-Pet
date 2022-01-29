using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOnPlayX : MonoBehaviour
{
    private Renderer[] renderers;

    // Start is called before the first frame update
    void Start()
    {
        renderers = GetComponentsInChildren<Renderer>();
        foreach (Renderer rend in renderers)
        {
            rend.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
