using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{


    public void ColourOn(Image _image)
    {
       _image.color = Color.red;
    }

    public void ColourOff(Image _image)
    {
        _image.color = Color.white;
    }

}
