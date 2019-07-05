using UnityEngine;
using System.Collections;

public class RightLazer : MonoBehaviour {


    public SPEEDUP SPEEDUP;
    public float speed;
    public float spawn;
    Vector3 Pos;
    // Use this for initialization
    void Start()
    {
        Pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * 10 * Time.deltaTime);
        if (transform.position.x >= Pos.x + 7.5)
        {
            Destroy(this.gameObject);
        }
    }
}