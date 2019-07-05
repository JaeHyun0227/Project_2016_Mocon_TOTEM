using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EXP : MonoBehaviour {

    public Text Text,Text2;
    public string Exp,LEVEL;
    public int exp = 0;
    public int Level = 1;
    void Start()
    {

        exp += PlayerPrefs.GetInt("Total", 0);
        PlayerPrefs.Save();
    }

    void Update()
    {
        if (exp >= 1000)
        {
            Level++;
            exp -= 1000;
        }
        Exp = exp.ToString();
        LEVEL = Level.ToString();
        Text.text = Exp + " | 1000 XP";
        Text2.text = LEVEL;
    }
}
