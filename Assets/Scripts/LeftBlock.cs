using System;
using UnityEngine;

public class LeftBlock : MonoBehaviour
{
    public static Action leftBlockChange;

    public void OnMouseDown()
    {
        leftBlockChange?.Invoke();
    }
}
