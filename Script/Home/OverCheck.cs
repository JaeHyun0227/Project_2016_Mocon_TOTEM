using UnityEngine;
using System.Collections;

public class OverCheck : MonoBehaviour {
    public bool asdasd;
    public GameObject ActiveObject;
    public bool Active;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && Active == true)
        {
            ActiveObject.SetActive(false);
            Active = false;
        } else if(Input.GetMouseButtonDown(0) && Active == false)
        {
            ActiveObject.SetActive(true);
            Active = true;
        }

        asdasd = true;
    }
    void OnMouseExit()
    {
        asdasd = false;
    }
}
