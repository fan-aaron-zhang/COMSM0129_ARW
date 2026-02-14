using UnityEngine;

public class GazeSelection : MonoBehaviour
{
    [SerializeField] private float rayDistance = 100f;
    private GameObject currentGazedObject = null;

    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            if (hit.collider.CompareTag("Interactable"))
            {
                if (currentGazedObject != hit.collider.gameObject)
                {
                    if (currentGazedObject != null)
                    {
                        currentGazedObject.GetComponent<InteractableObject>()?.OnGazeExit();
                    }

                    currentGazedObject = hit.collider.gameObject;
                    currentGazedObject.GetComponent<InteractableObject>()?.OnGazeEnter();
                }
            }
        }
        else
        {
            if (currentGazedObject != null)
            {
                currentGazedObject.GetComponent<InteractableObject>()?.OnGazeExit();
                currentGazedObject = null;
            }
        }
    }
}