using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

    public int speed = 1;
    public int cnt = 0;

    // Use this for initialization
    void Start() {
        StartCoroutine(Left());
        StartCoroutine(Right());
    }
    IEnumerator Right()
    {
        if (cnt != 0 && cnt <= 4)
        {
            cnt--;
            for (int i = 0; i < 18; i++)
            {
                yield return new WaitForSeconds((float)0.06);
                transform.Translate(new Vector2(1 * speed, 0));
            }
            
        }
    }
    IEnumerator Left()
    {
        if (cnt != 4 && cnt >= 0)
        {
            cnt++;
            for (int i = 0; i < 18; i++)
            {
                yield return new WaitForSeconds((float)0.06);
                transform.Translate(new Vector2(-1 * speed, 0));
            }
            
        }
    }
}
