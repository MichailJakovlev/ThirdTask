using System;
using UnityEngine;
using System.Collections;

public class DownBlock : MonoBehaviour
{
    public static Action downBlockChange;
    private Vector3 leftEdge;
    private Vector3 rightEdge;

    private void Start()
    {
        leftEdge.x = 0;
        rightEdge.x = Screen.width;
        leftEdge.y = gameObject.transform.position.y;
        rightEdge.y = gameObject.transform.position.y;
        gameObject.transform.position = leftEdge;
        
        StartCoroutine(BlockAnimation());
    }

    IEnumerator BlockAnimation()
    {
        while(true)
        { 
            for(float i = 0; i < 1; i+=Time.deltaTime)
            {
                gameObject.transform.position = Vector3.Lerp(leftEdge, rightEdge, i);

                yield return null;
            }
            
            gameObject.transform.position = rightEdge;

            for (float i = 0; i < 1; i += Time.deltaTime)
            {
                gameObject.transform.position = Vector3.Lerp(rightEdge, leftEdge, i);

                yield return null;
            }
            
            gameObject.transform.position = leftEdge;
            
            yield return null;
        }
    }

    public void OnMouseDown()
    {
        downBlockChange?.Invoke();
    }
}

    

