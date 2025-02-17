using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public int health;
    [SerializeField]
    private Camera camera;

    void Start()
    {
        health = 25;
        //camera = GetComponent<Camera>();
    }

    private void Update()
    {
        if (health <= 0)
        {
            print("You are dead.");
            GetComponent<FPSInput>().enabled = false;
            GetComponent<MouseLook>().enabled = false;
            camera.GetComponent<MouseLook>().enabled = false;
            camera.GetComponent<PlayerBullets>().enabled = false;
        }
    }

    public void hurt (int damage)
    {
        health -= damage;

        Debug.Log($"Health : {health}");
    }
}
