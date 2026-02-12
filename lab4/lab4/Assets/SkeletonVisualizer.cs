using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems; // 必须引用这个，才能使用 TrackingState
using Unity.Collections;

public class SkeletonVisualizer : MonoBehaviour
{
    private ARHumanBody _arBody;
    private LineRenderer _lineRenderer;

    void Awake()
    {
        _arBody = GetComponent<ARHumanBody>();
        _lineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        // 【修正点】: 不再检查 .pose3D，而是检查追踪状态
        // 如果没有正在追踪人，或者状态异常，就不画线
        if (_arBody.trackingState != TrackingState.Tracking)
        {
            _lineRenderer.positionCount = 0;
            return;
        }

        // 获取关节数据
        var joints = _arBody.joints;
        
        // 检查关节数据是否有效
        if (!joints.IsCreated || joints.Length == 0)
        {
            _lineRenderer.positionCount = 0;
            return;
        }

        // 开始画线
        _lineRenderer.positionCount = joints.Length;

        for (int i = 0; i < joints.Length; i++)
        {
            // 获取关节的局部坐标
            Vector3 jointLocalPos = joints[i].localPose.position;
            
            // 将局部坐标转换为世界坐标 (跟随人体移动)
            Vector3 worldPos = transform.TransformPoint(jointLocalPos);
            
            _lineRenderer.SetPosition(i, worldPos);
        }
    }
}