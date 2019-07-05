using UnityEngine;
using System.Collections;

public class BirdBuild : MonoBehaviour {

    public bool BirdB;
    public Diamond Dia;
    public GameObject Lock;
    public WoodBuild Check;
    // Use this for initialization
    void Start()
    {
        BirdB = false;
        PlayerPrefs.GetInt("BirdLock", 0);
        PlayerPrefs.Save();
        if (PlayerPrefs.GetInt("BirdLock", 0) == 1)
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
            if (Input.GetMouseButtonDown(0) && BirdB == true)
            {
                transform.localScale = new Vector3(0.02f, 0.065f, 0.065f);
                Check.Check = false;
                BirdB = false;
            }
            else if (Input.GetMouseButtonDown(0) && BirdB == false && Check.Check != true && PlayerPrefs.GetInt("BirdLock",0) == 1 && Dia.Dia >= 35)
            {
            PlayerPrefs.Save();
                transform.localScale = new Vector3(0.0225f, 0.075f, 0.065f);
                Check.Check = true;
                BirdB = true;
            }
    }
}