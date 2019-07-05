using UnityEngine;
using System.Collections;

public class WaveStartButton_1_6 : MonoBehaviour {

    public float spawnTime;
    public string num;
    public GameObject Monster;
    public GameObject Monster2;
    public SPEEDUP SPEEDUP;
    public Health Hp;
    public Sprite S1, S2;
    public GameObject Win, Lose, Page;
    public bool CoolTime;
    public int wave;
    public int cnt;

    // Use this for initialization
    void Start()
    {
        CoolTime = false;
        wave = 0;
        spawnTime = 1;
        Monster.SetActive(false);
        Monster2.SetActive(false);
    }

    Vector3 SetPos()
    {
        float posX = -0.1f;
        float posy = 0.65f;
        float posz = 90f;


        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(posX, posy, posz));
        return pos;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime = SPEEDUP.spawnTime;


        if (wave == 10 && cnt == -1 && Hp.HP >= 1)
        {
            Page.SetActive(true);
            Win.SetActive(true);
        }
        else if (Hp.HP <= 0)
        {
            Page.SetActive(true);
            Lose.SetActive(true);
        }
    }

    IEnumerator OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && CoolTime == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = S2;
            CoolTime = true;
            wave++;
            StartCoroutine(Wave());

            yield return new WaitForSeconds(30);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = S1;
            CoolTime = false;


        }
    }

    void Wolfspawn()
    {
        Monster.SetActive(true);
        Instantiate(Monster, SetPos(), Quaternion.identity);
        Monster.SetActive(false);

    }

    void Lionspawn()
    {
        Monster2.SetActive(true);
        Instantiate(Monster2, SetPos(), Quaternion.identity);
        Monster2.SetActive(false);
    }

    IEnumerator Wave()
    {
        int i;
        if (wave == 1)
        {
            for (i = 0; i < 10; i++)
            {
                yield return new WaitForSeconds(spawnTime);
                Wolfspawn();
            }
        }
        if (wave == 2)
        {
            for (i = 0; i < 15; i++)
            {
                yield return new WaitForSeconds(spawnTime);
                Wolfspawn();
            }
        }
        if (wave == 3)
        {
            for (i = 0; i < 20; i++)
            {
                yield return new WaitForSeconds(spawnTime);
                Wolfspawn();
            }
        }
        if (wave == 4)
        {
            for (i = 0; i < 20; i++)
            {
                yield return new WaitForSeconds(spawnTime);
                Wolfspawn();
            }
            for (i = 0; i < 5; i++)
            {
                yield return new WaitForSeconds(spawnTime);
                Lionspawn();
            }
        }
        if (wave == 5)
        {
            for (i = 0; i < 20; i++)
            {
                yield return new WaitForSeconds(spawnTime);
                Wolfspawn();
            }
            for (i = 0; i < 10; i++)
            {
                yield return new WaitForSeconds(spawnTime);
                Lionspawn();
            }
        }
        if (wave == 6)
        {
            for (i = 0; i < 20; i++)
            {
                yield return new WaitForSeconds(spawnTime);
                Wolfspawn();
            }
            for (i = 0; i < 15; i++)
            {
                yield return new WaitForSeconds(spawnTime);
                Lionspawn();
            }
        }
        if (wave == 7)
        {
            for (i = 0; i < 25; i++)
            {
                yield return new WaitForSeconds(spawnTime);
                Wolfspawn();
            }
            for (i = 0; i < 15; i++)
            {
                yield return new WaitForSeconds(spawnTime);
                Lionspawn();
            }
        }
        if (wave == 8)
        {
            for (i = 0; i < 25; i++)
            {
                yield return new WaitForSeconds(spawnTime);
                Wolfspawn();
            }
            for (i = 0; i < 20; i++)
            {
                yield return new WaitForSeconds(spawnTime);
                Lionspawn();
            }
        }
        if (wave == 9)
        {
            for (i = 0; i < 25; i++)
            {
                yield return new WaitForSeconds(spawnTime);
                Wolfspawn();
            }
            for (i = 0; i < 25; i++)
            {
                yield return new WaitForSeconds(spawnTime);
                Lionspawn();
            }
        }
        if (wave == 10)
        {
            cnt += 55;
            for (i = 0; i < 30; i++)
            {
                yield return new WaitForSeconds(spawnTime);
                Wolfspawn();
            }
            for (i = 0; i < 25; i++)
            {
                yield return new WaitForSeconds(spawnTime);
                Lionspawn();
            }
            cnt--;
        }
    }
}
