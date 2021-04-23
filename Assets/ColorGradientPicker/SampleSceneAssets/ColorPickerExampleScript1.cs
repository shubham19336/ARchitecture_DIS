using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPickerExampleScript1 : MonoBehaviour
{
    private Renderer r;
    //private Color tempc;
    void Start()
    {
        r = GetComponent<Renderer>();
        r.sharedMaterial = r.materials[1];

        //tempc = r.materials[0].color;
    }
    public void ChooseColorButtonClick()
    {
        ColorPicker.Create(r.sharedMaterial.color, "Choose Color!", SetColor, ColorFinished, true);

        Debug.Log("Choose");

    }
    private void SetColor(Color currentColor)
    {
        r.sharedMaterial.color = currentColor;

        Debug.Log("set color");
        
    }

    private void ColorFinished(Color finishedColor)
    {
        Debug.Log("You chose the color " + ColorUtility.ToHtmlStringRGBA(finishedColor));
        //r.sharedMaterial = r.materials[0];
        //r.sharedMaterial.color = tempc;
    }
}
