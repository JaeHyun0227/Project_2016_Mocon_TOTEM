using UnityEngine;
using System.Collections;

public class Invent : MonoBehaviour {

    public InventRight Page;
    public Coin Money;
    public GameObject[] Lock = new GameObject[4];
    public bool[] Open = new bool[4];
    public Sprite S1, S2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    IEnumerator OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = S1;
            yield return new WaitForSeconds(0.2f);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = S2;

            if (Page.Page == 0 && Money.money >= 500 && Open[0] == false)
            {
                Money.money -= 500;
                Destroy(Lock[0].gameObject);
                Open[0] = true;
                PlayerPrefs.SetInt("MushroomLock", 1);
            }
            else if(Page.Page == 1 && Money.money >= 1000 && Open[1] == false)
            {
                Money.money -= 1000;
                Destroy(Lock[1].gameObject);
                Open[1] = true;
                PlayerPrefs.SetInt("StoneLock", 1);
            }
            else if(Page.Page == 2 && Money.money >= 1500 && Open[2] == false)
            {
                Money.money -= 1500;
                Destroy(Lock[2].gameObject);
                Open[2] = true;
                PlayerPrefs.SetInt("SunLock", 1);
            }
            else if(Page.Page == 3 && Money.money >= 2000 && Open[3] == false)
            {
                Money.money -= 2000;
                Destroy(Lock[3].gameObject);
                Open[3] = true;
                PlayerPrefs.SetInt("BirdLock", 1);
            }
        }
    }
}
