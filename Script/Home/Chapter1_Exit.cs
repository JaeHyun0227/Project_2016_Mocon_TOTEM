using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;

public class Chapter1_Exit : MonoBehaviour {

    public GameObject Page;
    public Sprite S1, S2;
    IEnumerator OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = S1;
            yield return new WaitForSeconds(0.2f);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = S2;
            Page.SetActive(false);
        }
    }
}
