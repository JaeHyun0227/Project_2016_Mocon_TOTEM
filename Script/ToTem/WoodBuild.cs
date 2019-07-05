using UnityEngine;
using System.Collections;

public class WoodBuild : MonoBehaviour {

    public Diamond Dia;
    public bool WoodB;
    public bool Check;
	// Use this for initialization
	void Start () {
        WoodB = false;
        Check = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseOver()
    {
            if (Input.GetMouseButtonDown(0) && WoodB == true)
            {
                transform.localScale = new Vector3(0.02f, 0.065f, 0.065f);
                Check = false;
                WoodB = false;
            }
            else if (Input.GetMouseButtonDown(0) && WoodB == false && Check != true && Dia.Dia >= 5)
            {
                transform.localScale = new Vector3(0.0225f, 0.075f, 0.065f);
                Check = true;
                WoodB = true;
            }
    }
}
