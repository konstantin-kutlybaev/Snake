using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class UIPanel : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Snake Snake;
    public Vector2 posit;
    public void OnPointerUp(PointerEventData e)
    {
        float right = posit.x - e.position.x;
        float up = posit.y - e.position.y;
        
        if(Math.Abs(right) - Math.Abs(up) > 0)
        {
            if(right < 0)
            {
                Snake.Right();
            }
            else
            {
                Snake.Left();
            }
        }
        else
        {
            if (up < 0)
            {
                Snake.Up();
            }
            else
            {
                Snake.Down();
            }
        }
    }

    public void OnPointerDown(PointerEventData e)
    {
        posit = e.position;
    }
}
