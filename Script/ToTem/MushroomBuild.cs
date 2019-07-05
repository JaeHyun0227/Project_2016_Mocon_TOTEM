using UnityEngine;
using System.Collections;

public class MushroomBuild : MonoBehaviour {

    public Diamond Dia;
    public bool MushroomB;
    public WoodBuild Check;
    public GameObject Lock;
    // Use this for initialization
    void Start()
    {
        MushroomB = false;
        PlayerPrefs.GetInt("MushroomLock", 0);
        PlayerPrefs.Save();
        if(PlayerPrefs.GetInt("MushroomLock", 0) == 1)
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
            if (Input.GetMouseButtonDown(0) && MushroomB == true)
            {
                transform.localScale = new Vector3(0.02f, 0.065f, 0.065f);
                Check.Check = false;
                MushroomB = false;
            }
            else if (Input.GetMouseButtonDown(0) && MushroomB == false && Check.Check != true && PlayerPrefs.GetInt("MushroomLock", 0) == 1 && Dia.Dia >= 15)
            {
                PlayerPrefs.Save();
                transform.localScale = new Vector3(0.0225f, 0.075f, 0.065f);
                Check.Check = true;
                MushroomB = true;
            }
    }

}

