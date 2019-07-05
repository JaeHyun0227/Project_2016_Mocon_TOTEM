using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Diamond : MonoBehaviour {

    public int Dia;
    public string dia;
    public Text Text;
    int i = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        dia = Dia.ToString();
        Text.text = dia;


        i++;
        if (i >= 100)
        {
            Dia += 1;
            i = 0;
        }
    }
}
