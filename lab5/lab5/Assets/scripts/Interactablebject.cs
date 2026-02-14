using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] private Material highlightMaterial;
    private Material originalMaterial;
    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalMaterial = objectRenderer.material;
    }

    public void OnGazeEnter()
    {
        if (highlightMaterial != null)
        {
            objectRenderer.material = highlightMaterial;
        }
        Debug.Log("Gaze entered: " + gameObject.name);
    }

    public void OnGazeExit()
    {
        objectRenderer.material = originalMaterial;
        Debug.Log("Gaze exited: " + gameObject.name);
    }
}