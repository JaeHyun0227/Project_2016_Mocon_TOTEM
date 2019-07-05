using UnityEngine;
using System.Collections;

public class InventOpen : MonoBehaviour {

    public Sprite S;
    public GameObject Page;
    public GameObject[] Lock = new GameObject[4];
	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetInt("MushroomLock") == 1)
        {
            Destroy(Lock[0]);
        }
        if (PlayerPrefs.GetInt("StoneLock") == 1)
        {
            Destroy(Lock[1]);
        }
        if (PlayerPrefs.GetInt("SunLock") == 1)
        {
            Destroy(Lock[2]);
        }
        if (PlayerPrefs.GetInt("BirdLock") == 1)
        {
            Destroy(Lock[3]);
        }
    }
	
	// Update is called once per frame
	void Update () {
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = S;
            Page.SetActive(true);
        }
    }
}
