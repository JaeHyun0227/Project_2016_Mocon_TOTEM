using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class PageChange2 : MonoBehaviour {

    public GameObject P1, P2;
    public PageChange1 Check;
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
        if (Input.GetMouseButtonDown(0) && Check.Check == false)
        {
            Page2.gameObject.GetComponent<SpriteRenderer>().sprite = Page2S;
            Page1.gameObject.GetComponent<SpriteRenderer>().sprite = Page1S;
            Vector3 P1pos = P1.transform.position;
            Vector3 P2pos = P2.transform.position;
            Check.Check = true;
            P1.transform.position = P2pos;
            P2.transform.position = P1pos;
            Text1.SetActive(false);
            Text2.SetActive(false);
        }
    }
}
