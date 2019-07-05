using UnityEngine;
using System.Collections;

public class InventRight : MonoBehaviour {

    public int Page=0;
    public GameObject[] P = new GameObject[4];
    public Sprite S,S2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    IEnumerator OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && Page <= 2)
        {
            Page++;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = S;
            P[Page-1].SetActive(false);
            P[Page].SetActive(true);
            yield return new WaitForSeconds(0.2f);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = S2;
        }
    }
}
