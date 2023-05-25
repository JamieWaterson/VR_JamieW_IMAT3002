using UnityEngine;
using System.Collections;
public class MoveCube : MonoBehaviour
{
    public GameObject MoveableCube;
    
    void Update()
    {
        Transform camera = Camera.main.transform;
        Ray ray;
        RaycastHit hit;
        GameObject hitObject;
        Debug.DrawRay(camera.position, camera.rotation *
        Vector3.forward * 100.0f);
        ray = new Ray(camera.position, camera.rotation *
        Vector3.forward);

        if (Physics.Raycast(ray, out hit))
        {
            hitObject = hit.collider.gameObject;
            if (hitObject == MoveableCube)
            {
                MoveableCube.transform.position += new Vector3(0, 0.1f, 0);
                StartCoroutine(waiter());
            }
        }
        IEnumerator waiter()
        {
            yield return new WaitForSeconds(8);
            MoveableCube.transform.position += new Vector3(0, -0.1f, 0);

        }
    }
}

