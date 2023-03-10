using System;
using UnityEngine;

public class UpBlock : MonoBehaviour
{
    public static Action upBlockChange;

    public void OnMouseDown()
    {
        upBlockChange?.Invoke();
    }
}
