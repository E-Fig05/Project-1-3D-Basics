using System.Collections;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    public int wave;

    [SerializeField]
    private GameObject enemyPrefab;

    [SerializeField]
    private bool WaveStart;
    private bool WaveEnd;

    public GameObject WavePlayer;

    private GameObject enemy;
    private GameObject enemy2;
    private GameObject enemy3;

    void Start()
    {
        wave = 1;
        WaveStart = true;
        WaveEnd = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(wave == 1)
        {
            if (WaveStart == true)
            {
                if (enemy == null)
                {
                    enemy = Instantiate(enemyPrefab) as GameObject;
                    enemy.transform.position = new Vector3(0, 1, 0);
                    enemy.GetComponent<WanderingAI>().health = 1;
                    enemy.GetComponent<WanderingAI>().player = WavePlayer;
                    float angle = Random.Range(0, 360);
                    enemy.transform.Rotate(0, angle, 0);
                    WaveStart = false;
                }
            }
            else
            {
                if (enemy == null)
                {
                    if (WaveEnd == true)
                    {
                        StartCoroutine(NextWave());
                        WaveEnd = false;
                    }
                }
            }
        }
        else if(wave == 2)
        {
            if (WaveStart == true)
            {
                if (enemy == null && enemy2 == null)
                {
                    //Spawn Enemy 1
                    enemy = Instantiate(enemyPrefab) as GameObject;
                    enemy.transform.position = new Vector3(0, 1, 0);
                    enemy.GetComponent<WanderingAI>().health = 2;
                    enemy.GetComponent<WanderingAI>().player = WavePlayer;
                    float angle = Random.Range(0, 360);
                    enemy.transform.Rotate(0, angle, 0);
                    
                    //Spawn Enemy 2
                    enemy2 = Instantiate(enemyPrefab) as GameObject;
                    enemy2.transform.position = new Vector3(0, 1, 0);
                    enemy2.transform.Rotate(0, angle + 180, 0);
                    enemy2.GetComponent<WanderingAI>().health = 2;
                    enemy2.GetComponent<WanderingAI>().player = WavePlayer;
                    WaveStart = false;
                }
            }
            else
            {
                if (enemy == null && enemy2 == null)
                {
                    if (WaveEnd == true)
                    {
                        StartCoroutine(NextWave());
                        WaveEnd = false;
                    }
                }
            }
        }
        else if(wave == 3)
        {
            if (WaveStart == true)
            {
                if (enemy == null && enemy2 == null && enemy3 == null)
                {
                    //Spawn Enemy 1
                    enemy = Instantiate(enemyPrefab) as GameObject;
                    enemy.transform.position = new Vector3(0, 1, 0);
                    enemy.GetComponent<WanderingAI>().health = 3;
                    enemy.GetComponent<WanderingAI>().player = WavePlayer;
                    float angle = Random.Range(0, 360);
                    enemy.transform.Rotate(0, angle, 0);

                    //Spawn Enemy 2
                    enemy2 = Instantiate(enemyPrefab) as GameObject;
                    enemy2.transform.position = new Vector3(0, 1, 0);
                    enemy2.transform.Rotate(0, angle + 120, 0);
                    enemy2.GetComponent<WanderingAI>().health = 3;
                    enemy2.GetComponent<WanderingAI>().player = WavePlayer;
                    WaveStart = false;

                    //Spawn Enemy 3
                    enemy3 = Instantiate(enemyPrefab) as GameObject;
                    enemy3.transform.position = new Vector3(0, 1, 0);
                    enemy3.transform.Rotate(0, angle + 240, 0);
                    enemy3.GetComponent<WanderingAI>().health = 3;
                    enemy3.GetComponent<WanderingAI>().player = WavePlayer;
                    WaveStart = false;
                }
            }
            else
            {
                if (enemy == null && enemy2 == null && enemy3 == null)
                {
                    if (WaveEnd == true)
                    {
                        StartCoroutine(NextWave());
                        WaveEnd = false;
                    }
                }
            }
        }
        else if(wave == 4)
        {
            if (WaveStart == true)
            {
                print("You Win");
                WaveStart = false;
            }
        }
        else if(wave == 5)
        {
            //Wave Five is just here for fun, it can't actually be accessed unless you set it to 5 manually in the editor.
            if (enemy == null && enemy2 == null && enemy3 == null)
            {
                //Spawn Enemy 1
                enemy = Instantiate(enemyPrefab) as GameObject;
                enemy.transform.position = new Vector3(0, 1, 0);
                enemy.GetComponent<WanderingAI>().health = 3;
                float angle = Random.Range(0, 360);
                enemy.transform.Rotate(0, angle, 0);

                //Spawn Enemy 2
                enemy2 = Instantiate(enemyPrefab) as GameObject;
                enemy2.transform.position = new Vector3(0, 1, 0);
                enemy2.transform.Rotate(0, angle + 120, 0);
                enemy2.GetComponent<WanderingAI>().health = 3;
                WaveStart = false;

                //Spawn Enemy 3
                enemy3 = Instantiate(enemyPrefab) as GameObject;
                enemy3.transform.position = new Vector3(0, 1, 0);
                enemy3.transform.Rotate(0, angle + 240, 0);
                enemy3.GetComponent<WanderingAI>().health = 3;
                WaveStart = false;

                //Spawn Enemy 4
                enemy = Instantiate(enemyPrefab) as GameObject;
                enemy.transform.position = new Vector3(0, 1, 0);
                enemy.GetComponent<WanderingAI>().health = 3;
                enemy.transform.Rotate(0, angle, 0);

                //Spawn Enemy 5
                enemy2 = Instantiate(enemyPrefab) as GameObject;
                enemy2.transform.position = new Vector3(0, 1, 0);
                enemy2.transform.Rotate(0, angle + 120, 0);
                enemy2.GetComponent<WanderingAI>().health = 3;
                WaveStart = false;

                //Spawn Enemy 6
                enemy3 = Instantiate(enemyPrefab) as GameObject;
                enemy3.transform.position = new Vector3(0, 1, 0);
                enemy3.transform.Rotate(0, angle + 240, 0);
                enemy3.GetComponent<WanderingAI>().health = 3;
                WaveStart = false;
                
                //Spawn Enemy 7
                enemy = Instantiate(enemyPrefab) as GameObject;
                enemy.transform.position = new Vector3(0, 1, 0);
                enemy.GetComponent<WanderingAI>().health = 3;
                enemy.transform.Rotate(0, angle, 0);

                //Spawn Enemy 8
                enemy2 = Instantiate(enemyPrefab) as GameObject;
                enemy2.transform.position = new Vector3(0, 1, 0);
                enemy2.transform.Rotate(0, angle + 120, 0);
                enemy2.GetComponent<WanderingAI>().health = 3;
                WaveStart = false;

                //Spawn Enemy 9
                enemy3 = Instantiate(enemyPrefab) as GameObject;
                enemy3.transform.position = new Vector3(0, 1, 0);
                enemy3.transform.Rotate(0, angle + 240, 0);
                enemy3.GetComponent<WanderingAI>().health = 3;
                WaveStart = false;

                //Spawn Enemy 10
                enemy = Instantiate(enemyPrefab) as GameObject;
                enemy.transform.position = new Vector3(0, 1, 0);
                enemy.GetComponent<WanderingAI>().health = 3;
                enemy.transform.Rotate(0, angle, 0);

                //Spawn Enemy 11
                enemy2 = Instantiate(enemyPrefab) as GameObject;
                enemy2.transform.position = new Vector3(0, 1, 0);
                enemy2.transform.Rotate(0, angle + 120, 0);
                enemy2.GetComponent<WanderingAI>().health = 3;
                WaveStart = false;

                //Spawn Enemy 12
                enemy3 = Instantiate(enemyPrefab) as GameObject;
                enemy3.transform.position = new Vector3(0, 1, 0);
                enemy3.transform.Rotate(0, angle + 240, 0);
                enemy3.GetComponent<WanderingAI>().health = 3;
                WaveStart = false;

                //Spawn Enemy 13
                enemy = Instantiate(enemyPrefab) as GameObject;
                enemy.transform.position = new Vector3(0, 1, 0);
                enemy.GetComponent<WanderingAI>().health = 3;
                enemy.transform.Rotate(0, angle, 0);

                //Spawn Enemy 14
                enemy2 = Instantiate(enemyPrefab) as GameObject;
                enemy2.transform.position = new Vector3(0, 1, 0);
                enemy2.transform.Rotate(0, angle + 120, 0);
                enemy2.GetComponent<WanderingAI>().health = 3;
                WaveStart = false;

                //Spawn Enemy 15
                enemy3 = Instantiate(enemyPrefab) as GameObject;
                enemy3.transform.position = new Vector3(0, 1, 0);
                enemy3.transform.Rotate(0, angle + 240, 0);
                enemy3.GetComponent<WanderingAI>().health = 3;
                WaveStart = false;

                //Spawn Enemy 16
                enemy = Instantiate(enemyPrefab) as GameObject;
                enemy.transform.position = new Vector3(0, 1, 0);
                enemy.GetComponent<WanderingAI>().health = 3;
                enemy.transform.Rotate(0, angle, 0);

                //Spawn Enemy 17
                enemy2 = Instantiate(enemyPrefab) as GameObject;
                enemy2.transform.position = new Vector3(0, 1, 0);
                enemy2.transform.Rotate(0, angle + 120, 0);
                enemy2.GetComponent<WanderingAI>().health = 3;
                WaveStart = false;

                //Spawn Enemy 18
                enemy3 = Instantiate(enemyPrefab) as GameObject;
                enemy3.transform.position = new Vector3(0, 1, 0);
                enemy3.transform.Rotate(0, angle + 240, 0);
                enemy3.GetComponent<WanderingAI>().health = 3;
                WaveStart = false;

                //Spawn Enemy 19
                enemy = Instantiate(enemyPrefab) as GameObject;
                enemy.transform.position = new Vector3(0, 1, 0);
                enemy.GetComponent<WanderingAI>().health = 3;
                enemy.transform.Rotate(0, angle, 0);

                //Spawn Enemy 20
                enemy2 = Instantiate(enemyPrefab) as GameObject;
                enemy2.transform.position = new Vector3(0, 1, 0);
                enemy2.transform.Rotate(0, angle + 120, 0);
                enemy2.GetComponent<WanderingAI>().health = 3;
                WaveStart = false;

                //Spawn Enemy 21
                enemy3 = Instantiate(enemyPrefab) as GameObject;
                enemy3.transform.position = new Vector3(0, 1, 0);
                enemy3.transform.Rotate(0, angle + 240, 0);
                enemy3.GetComponent<WanderingAI>().health = 3;
                WaveStart = false;

                //Spawn Enemy 22
                enemy = Instantiate(enemyPrefab) as GameObject;
                enemy.transform.position = new Vector3(0, 1, 0);
                enemy.GetComponent<WanderingAI>().health = 3;
                enemy.transform.Rotate(0, angle, 0);

                //Spawn Enemy 23
                enemy2 = Instantiate(enemyPrefab) as GameObject;
                enemy2.transform.position = new Vector3(0, 1, 0);
                enemy2.transform.Rotate(0, angle + 120, 0);
                enemy2.GetComponent<WanderingAI>().health = 3;
                WaveStart = false;

                //Spawn Enemy 24
                enemy3 = Instantiate(enemyPrefab) as GameObject;
                enemy3.transform.position = new Vector3(0, 1, 0);
                enemy3.transform.Rotate(0, angle + 240, 0);
                enemy3.GetComponent<WanderingAI>().health = 3;
                WaveStart = false;
            }
        }
    }

    private IEnumerator NextWave()
    {
        yield return new WaitForSeconds(3f);
        this.wave += 1;
        this.WaveStart = true;
        this.WaveEnd = true;
    }
}
