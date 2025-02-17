using System.Collections;
using UnityEngine;

public class PlayerBullets : MonoBehaviour
{
    private Camera camera;

    [SerializeField]
    private GameObject bulletPrefab;

    private GameObject bullet;


    void Start()
    {
        camera = GetComponent<Camera>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //0 = Left Mouse Button
        if (Input.GetMouseButtonDown(0))
        {

            bullet = Instantiate(bulletPrefab) as GameObject;

            bullet.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
            bullet.transform.rotation = transform.rotation;

        }
    }//Update End

    /*private IEnumerator SphereIndicator(Vector3 position)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = position;

        yield return new WaitForSeconds(1);

        Destroy(sphere);
    }//end Sphere Indicator*/

    private void OnGUI()
    {
        int size = 24;
        float posX = camera.pixelWidth / 2 - size / 4;
        float posY = camera.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(posX, posY, size, size), "*");
    }
}
