using UnityEngine;
using System.Collections;

public class Chapter1_Open : MonoBehaviour {

    public Button cnt;
    public GameObject Page;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0) && cnt.cnt == 1)
        {
            Page.SetActive(true);
        }
    }
}
