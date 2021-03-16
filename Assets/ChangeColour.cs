using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    public Material unselected;
    public Material selected;
    Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        renderer.material = selected;
    }

    void OnMouseUp()
    {
        renderer.material = unselected;
    }
}
