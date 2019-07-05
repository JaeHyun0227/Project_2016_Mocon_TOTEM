using UnityEngine;
using System.Collections;

public class UpLazer : MonoBehaviour {

    Vector3 Pos;
    // Use this for initialization
    void OnTriggerEnter(Collider col)
    {
    }
    void Start()
    {
        Pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * 10 * Time.deltaTime);
        if (transform.position.y >= Pos.y + 5.5)
        {
            Destroy(this.gameObject);
        }
    }
}
