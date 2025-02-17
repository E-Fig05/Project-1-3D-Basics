using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField]
    private float speed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }


    //Take health from enemy and destroy on hit.
    private void OnTriggerEnter(Collider other)
    {
        ReactiveTarget enemy = other.GetComponent<ReactiveTarget>();
        if (enemy != null)
        {
            enemy.ReactToHit();
            print(other.GetComponent<WanderingAI>().health);
        }
        Destroy(this.gameObject);
    }

}
