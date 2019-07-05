using UnityEngine;
using System.Collections;

public class SunBuild : MonoBehaviour {

    public bool SunB;
    public Diamond Dia;
    public GameObject Lock;
    public WoodBuild Check;
    // Use this for initialization
    void Start()
    {
        SunB = false;
        PlayerPrefs.GetInt("SunLock", 0);
        PlayerPrefs.Save();
        if (PlayerPrefs.GetInt("SunLock", 0) == 1)
        {
            Destroy(Lock.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {
            if (Input.GetMouseButtonDown(0) && SunB == true)
            {
                transform.localScale = new Vector3(0.02f, 0.065f, 0.065f);
                Check.Check = false;
                SunB = false;
            }
            else if (Input.GetMouseButtonDown(0) && SunB == false && Check.Check != true && PlayerPrefs.GetInt("SunLock",0) == 1 && Dia.Dia >= 25)
            {
            PlayerPrefs.Save();
                transform.localScale = new Vector3(0.0225f, 0.075f, 0.065f);
                Check.Check = true;
                SunB = true;
            }
    }
}
