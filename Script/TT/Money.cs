using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Money : MonoBehaviour {

    public Text Text1, Text2, Text3;
    public string Total;
    public int money=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Total = money.ToString();

        Text1.text = Total;
        Text2.text = Total;
        Text3.text = Total;


        PlayerPrefs.SetInt("Total", money);
	}
}
