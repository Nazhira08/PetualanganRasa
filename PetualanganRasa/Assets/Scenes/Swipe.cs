using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    public Sprite PageImage;
    public List<Sprite> Numbers;
    public int PageNumber;

    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;
    
    private void Update()
    {
        if(Input.touchCount>0&&Input.GetTouch(0).phase==TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }

        if(Input.touchCount>0&&Input.GetTouch(0).phase==TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;

            if(endTouchPosition.x < startTouchPosition.x)
            {
                NextPage();
            }

            if(endTouchPosition.x > startTouchPosition.x)
            {
                PreviousPage();
            }
        }
    }

    private void PreviousPage()
    {
        PageNumber--;
        PageImage.sprite = Numbers[PageNumber];
    }

    private void NextPage()
    {
        PageNumber++;
        PageImage.sprite = Numbers[PageNumber];
    }
}
