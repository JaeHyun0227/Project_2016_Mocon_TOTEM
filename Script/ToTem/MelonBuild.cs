using UnityEngine;
using System.Collections;

public class MelonBuild : MonoBehaviour {

    public bool MelonB;
    public Diamond Dia;
    public WoodBuild Check;
    // Use this for initialization
    void Start()
    {
        MelonB = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {
            if (Input.GetMouseButtonDown(0) && MelonB == true)
            {
                transform.localScale = new Vector3(0.02f, 0.065f, 0.065f);
                Check.Check = false;
                MelonB = false;
            }
            else if (Input.GetMouseButtonDown(0) && MelonB == false && Check.Check != true && Dia.Dia >= 5)
            {
                transform.localScale = new Vector3(0.0225f, 0.075f, 0.065f);
                Check.Check = true;
                MelonB = true;
            }
    }

}

