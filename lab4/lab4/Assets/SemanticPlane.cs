using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class SemanticPlane : MonoBehaviour
{
    [Header("必须配置的材质球")]
    [SerializeField] private Material _floorMat;    // 地板 (绿色)
    [SerializeField] private Material _tableMat;    // 桌子 (蓝色)
    [SerializeField] private Material _wallMat;     // 墙壁 (黄色)
    [SerializeField] private Material _ceilingMat;  // 天花板 (青色)
    [SerializeField] private Material _seatMat;     // 座位 (紫色)
    [SerializeField] private Material _doorMat;     // 门/窗 (橙色)
    [SerializeField] private Material _otherMat;    // 未识别 (红色)

    private ARPlane _arPlane;
    private MeshRenderer _renderer;

    void Awake()
    {
        _arPlane = GetComponent<ARPlane>();
        _renderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        // 1. 地板
        if (_arPlane.classifications.HasFlag(PlaneClassifications.Floor))
        {
            _renderer.material = _floorMat;
        }
        // 2. 桌子
        else if (_arPlane.classifications.HasFlag(PlaneClassifications.Table))
        {
            _renderer.material = _tableMat;
        }
        // 3. 【修正】墙壁 (注意这里改成了 WallFace)
        else if (_arPlane.classifications.HasFlag(PlaneClassifications.WallFace))
        {
            _renderer.material = _wallMat;
        }
        // 4. 天花板
        else if (_arPlane.classifications.HasFlag(PlaneClassifications.Ceiling))
        {
            _renderer.material = _ceilingMat;
        }
        // 5. 座位
        else if (_arPlane.classifications.HasFlag(PlaneClassifications.Seat))
        {
            _renderer.material = _seatMat;
        }
        // 7. 其他
        else
        {
            _renderer.material = _otherMat;
        }
    }
}