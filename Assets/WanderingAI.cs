using System.Collections;
using UnityEngine;

public class WanderingAI : MonoBehaviour
{
    [SerializeField]
    private float speed = 3.0f;

    [SerializeField]
    private float obstacleRange = 5.0f;

    private bool isAlive;

    public float health = 5;

    [SerializeField]
    private GameObject fireballPrefab;

    [SerializeField]
    private bool CanShoot = true;

    private GameObject fireball;

    public GameObject player;

    private void Start()
    {
        isAlive = true;
    }

    public void SetAlive(bool isAlive)
    {
        this.isAlive = isAlive;
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive && player.GetComponent<PlayerCharacter>().health > 0)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.SphereCast(ray, 0.75f, out hit));
        {
            if (isAlive)
            {
                //print(hit.transform);
                GameObject hitObject = hit.transform.gameObject;

                if (hitObject.GetComponent<PlayerCharacter>())
                {
                    if (fireball == null)
                    {
                        if (CanShoot == true)
                        {
                            fireball = Instantiate(fireballPrefab) as GameObject;

                            fireball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                            fireball.transform.rotation = transform.rotation;
                            StartCoroutine(Cooldown());
                            CanShoot = false;
                        }
                    }
                }
                else if (hit.distance < obstacleRange)
                {
                    float angle = Random.Range(-110, 110);
                    transform.Rotate(0, angle, 0);
                }
            }
        }
    }

    private IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(1);
        CanShoot = true;
    }
}
