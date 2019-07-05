using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;
public class Cancle : MonoBehaviour {

    public GameObject P1;
    public Sprite S;
    public GameObject Button;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Button.gameObject.GetComponent<SpriteRenderer>().sprite = S;
            P1.SetActive(false);
        }
    }
}
