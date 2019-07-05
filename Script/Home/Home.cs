using UnityEngine;
using System.Collections;

public class Home : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        PlayerPrefs.SetInt("MushroomLock",0);
        PlayerPrefs.SetInt("StoneLock", 0);
        PlayerPrefs.SetInt("SunLock", 0);
        PlayerPrefs.SetInt("BirdLock", 0);
        PlayerPrefs.Save();
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Home");
        }
    }
}
