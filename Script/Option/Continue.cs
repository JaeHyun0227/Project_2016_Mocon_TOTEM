using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;
public class Continue : MonoBehaviour {

    public GameObject Option;
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
            Option.SetActive(false);
        }
    }
}
