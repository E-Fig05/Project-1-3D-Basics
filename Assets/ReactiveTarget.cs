using System.Collections;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
    [SerializeField]
    private GameObject pickupPrefab;

    private GameObject pickup;

    public void ReactToHit()
    {
        WanderingAI behavior = GetComponent<WanderingAI>();

        if(behavior != null)
        {
            if (behavior.health > 1)
            {
                behavior.health -= 1;
            }
            else
            {
                behavior.health = 0;
                behavior.SetAlive(false);
                StartCoroutine(Die());
            }
        }
    }

    private IEnumerator Die()
    {
        this.transform.Rotate(-75, 0, 0);

        yield return new WaitForSeconds(1.5f);

        pickup = Instantiate(pickupPrefab) as GameObject;
        pickup.transform.position = transform.position;

        Destroy(this.gameObject);
    }
}
