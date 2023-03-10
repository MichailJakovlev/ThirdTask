using System;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public static Action cubeChange;

    private void OnMouseDown()
    {
        cubeChange?.Invoke();
    }
}

