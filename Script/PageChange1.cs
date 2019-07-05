using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;

public class PageChange1 : MonoBehaviour {

    public GameObject P1, P2;
    public bool Check = false;
    public GameObject Page1, Page2;
    public Sprite Page1S, Page2S;
    public GameObject Text1, Text2;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && Check == true)
        {
            Page1.gameObject.GetComponent<SpriteRenderer>().sprite = Page1S;
            Page2.gameObject.GetComponent<SpriteRenderer>().sprite = Page2S;
            Vector3 P1pos = P1.transform.position;
            Vector3 P2pos = P2.transform.position;
            Check = false;
            P1.transform.position = P2pos;
            P2.transform.position = P1pos;
            Text1.SetActive(true);
            Text2.SetActive(true);
        }
    }
}