using UnityEngine;
using System.Collections;

public class TT_Exit : MonoBehaviour {

    public Sprite S,S2;
    public GameObject Page;

    IEnumerator OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = S;
            yield return new WaitForSeconds(0.2f);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = S2;
            Page.SetActive(false);
        }
    }
}
