using UnityEngine;
using TMPro;
using UnityEngine.XR.ARFoundation;

public class BodyDebug : MonoBehaviour
{
    public ARHumanBodyManager bodyManager; // 记得在 Inspector 里把 XR Origin 拖进来
    private TMP_Text _text;

    void Start()
    {
        _text = GetComponent<TMP_Text>();
    }

    void Update()
    {
        if (bodyManager == null) 
        {
            _text.text = "Manager is NULL";
            return;
        }

        int count = bodyManager.trackables.count;
        var subsystem = bodyManager.subsystem;

        if (subsystem != null && !subsystem.running)
        {
            _text.text = "AR Subsystem Stopped!";
        }
        else if (count == 0)
        {
            _text.text = "Scanning... No Body Found";
        }
        else
        {
            _text.text = "Body Detected! Count: " + count;
        }
    }
}