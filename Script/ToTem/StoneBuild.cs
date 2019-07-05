using UnityEngine;
using System.Collections;

public class StoneBuild : MonoBehaviour {

    public bool StoneB;
    public Diamond Dia;
    public GameObject Lock;
    public WoodBuild Check;
    // Use this for initialization
    void Start()
    {
        StoneB = false;
        PlayerPrefs.GetInt("StoneLock", 0);
        PlayerPrefs.Save();
        if (PlayerPrefs.GetInt("StoneLock", 0) == 1)
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
            if (Input.GetMouseButtonDown(0) && StoneB == true)
            {
                transform.localScale = new Vector3(0.02f, 0.065f, 0.065f);
                Check.Check = false;
                StoneB = false;
            }
            else if (Input.GetMouseButtonDown(0) && StoneB == false && Check.Check != true && PlayerPrefs.GetInt("StoneLock",0) == 1 && Dia.Dia >= 25)
            {
            PlayerPrefs.Save();
                transform.localScale = new Vector3(0.0225f, 0.075f, 0.065f);
                Check.Check = true;
                StoneB = true;
            }
    }
}
