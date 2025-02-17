using System.Collections;
using UnityEngine;

public class RayShooter : MonoBehaviour
{
    private Camera camera;

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
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 point = new Vector3(camera.pixelWidth / 2, camera.pixelHeight / 2, 0);
            Ray ray = camera.ScreenPointToRay(point);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;
                ReactiveTarget target = hitObject.GetComponent<ReactiveTarget>();

                if(target != null)
                {
                    target.ReactToHit();
                }
                else
                {
                    StartCoroutine(SphereIndicator(hit.point));
                }

                
            }//end if Physics.Raycast
        }
    }//Update End

    private IEnumerator SphereIndicator(Vector3 position)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = position;

        yield return new WaitForSeconds(1);

        Destroy(sphere);
    }//end Sphere Indicator

    private void OnGUI()
    {
        int size = 24;
        float posX = camera.pixelWidth/ 2 - size / 4;
        float posY = camera.pixelHeight/ 2 - size / 2;
        GUI.Label(new Rect(posX, posY, size, size), "*");
    }
}
