using UnityEngine;
using System.Collections;

public class InventExit : MonoBehaviour {

    public GameObject Page;
    public GameObject icon;
    public Sprite S,S2,S3;
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
            this.gameObject.GetComponent<SpriteRenderer>().sprite = S;
            yield return new WaitForSeconds(0.2f);
            Page.SetActive(false);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = S2;
            icon.gameObject.GetComponent<SpriteRenderer>().sprite = S3;
        }

    }
}
