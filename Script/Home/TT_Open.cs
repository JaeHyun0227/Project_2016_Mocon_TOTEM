using UnityEngine;
using System.Collections;

public class TT_Open : MonoBehaviour {

    public GameObject Page;
    public Button cnt;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && cnt.cnt == 0)
        {
            Page.SetActive(true);
        }
    }
}
