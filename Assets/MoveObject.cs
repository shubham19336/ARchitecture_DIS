using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveObject : MonoBehaviour
{
    //public Text TextBox;
    public List<GameObject> maps;

    private static Transform ob;
    public Slider slidex;
    public Slider slidez;
    public Toggle togl;
    public GameObject canvas ;
    public Text textbox;

    //private const float h;

    void Start()
    {

        var dropdown = transform.GetComponent<Dropdown>();

        dropdown.options.Clear();

        List<string> opt = new List<string>();
        opt.Add("None");
        opt.Add("Sofa");
        opt.Add("Dining");
        opt.Add("Table");

        foreach (var i in opt)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = i });
        }

        dropdown.onValueChanged.AddListener(delegate { OptionSelected(dropdown); });

        textbox.text = "None";
    }

    void OptionSelected(Dropdown dropdown)
    {
        int i = dropdown.value;
        Debug.Log(i);

        for (int k = 0; k < maps.Count; k++)
        {
            if (k == i)
            {
                //Debug.Log(i);
                //maps[k].SetActive(true);

                ob = maps[k].transform;
                //Debug.Log(ob.name);
                //ob.transform.localScale = new Vector3(.5f, .5f, .5f);
                //Debug.Log("xxx  " + x);
                //this.earth = maps[k].transform.GetChild(0);
                //Debug.Log(this.earth.name);

                //maps[k].transform.GetChild(0).GetChild(0).GetChild(0).gameObject.SetActive(false);
            }

            else
            {
                //maps[k].SetActive(false);
            }
        }
    }

    public void MoveXi()
    {
        //Debug.Log("xxx  " + x);
        float k = slidex.value;
        Debug.Log("slll   "+k);
        k = k - 0.5f;
        //float h = ob.localPosition.x;
        string s = ob.name;

        if (string.Equals(s,"PFB_Sofa"))
            ob.localPosition += new Vector3(2*k-ob.localPosition.x, 0f, 0f);

        if (string.Equals(s, "Dine"))
            ob.localPosition += new Vector3(2 * k - ob.localPosition.x, 0f, 0f);

        if (string.Equals(s, "Table"))
            ob.localPosition += new Vector3(2 * k - ob.localPosition.x, 0f, 0f);

        Debug.Log(ob.position);
    }

    public void MoveXd()
    {
        //Debug.Log("xxx  " + x);

        ob.localPosition += new Vector3(-.05f, 0f, 0f);
        Debug.Log(ob.position);
        //Debug.Log(ob.transform.localScale);
    }

    public void MoveZi()
    {
        //Debug.Log("xxx  " + x);
        float k = slidez.value;
        k = k - 0.5f;
        string s = ob.name;
        //float h = ob.localPosition.z;

        if (string.Equals(s,"PFB_Sofa"))
            ob.localPosition += new Vector3(0f, 0f,3+2*k-ob.localPosition.z);

        if (string.Equals(s,"Dine"))
            ob.localPosition += new Vector3(0f, 0f, 2 * k - ob.localPosition.z);

        if (string.Equals(s, "Table"))
            ob.localPosition += new Vector3(0f, 0f, 2 * k - ob.localPosition.z);

        //Debug.Log(ob.transform.localScale);
    }

    public void MoveZd()
    {
        //Debug.Log("xxx  " + x);

        ob.transform.position += new Vector3(0f, 0f, -.1f);
        //Debug.Log(ob.transform.localScale);
    }

    public void ShowCanvas()
    {
        if (togl.isOn)
        {
            canvas.SetActive(true);
        } else
        {
            canvas.SetActive(false);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
