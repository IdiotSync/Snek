using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    /*function resizeCamera()
    {
        int PrevWidth = Screen.width;
        int PrevHeight = Screen.height;

        var screenRatio = PrevWidth / PrevHeight;
        var relativeWidth = HardcodedRatioWidth / PrevWidth;
        var relativeHeight = HardcodedRatioHeight / PrevHeight;

        if (screenRatio < HardcodedRatioWidth / HardcodedRatioHeight)
        {
            var hAdjustment = relativeHeight / relativeWidth;
            var yAdjustment = (1 - hAdjustment) / 2;
            thisCamera.rect = Rect(0, yAdjustment, 1, hAdjustment);
        }
        else
        {
            var wAdjustment = relativeWidth / relativeHeight;
            var xAdjustment = (1 - wAdjustment) / 2;
            thisCamera.rect = Rect(xAdjustment, 0, wAdjustment, 1);
        }
    }*/
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
