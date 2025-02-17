using System.Collections;
using UnityEngine;

public class PickupBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Despawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Despawn()
    {
        yield return new WaitForSeconds(25);
        Destroy(this.gameObject);
    }


    //Collision Detection
    private void OnTriggerEnter(Collider other)
    {
        PlayerCharacter player = other.GetComponent<PlayerCharacter>();
        if (player != null)
        {
            player.health += 2;
        }
        Destroy(this.gameObject);
    }
}
