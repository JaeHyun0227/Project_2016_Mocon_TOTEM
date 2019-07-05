using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Coin : MonoBehaviour {

    public Text Text;
    public string Money;
    public int money = 0;
	// Use this for initialization
	void Start () {
        money += PlayerPrefs.GetInt("Total", 0);
        PlayerPrefs.SetInt("Total", 0);
        PlayerPrefs.Save();
	}
	
	// Update is called once per frame
	void Update () {
        Money = money.ToString();
        Text.text = Money;
	}
}
