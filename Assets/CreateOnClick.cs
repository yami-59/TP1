using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CreateOnClick : MonoBehaviour
{
    [Header("Projectile Setup")]
    public GameObject aCopier;          // 拖你的 ProjectilePrefab 到这里
    public float spawnDistance = 1.2f;  // 生成在玩家前方的距离
    public float launchForce = 15f;     // 发射冲量
    public float lifeTime = 10f;        // 多少秒后自动销毁

    [Tooltip("如果玩家有Collider/CharacterController，建议勾选，自动忽略首帧碰撞")]
    public bool ignoreInitialCollision = true;

    // ⬇⬇⬇ 关键：改成 InputValue，而不是 CallbackContext
    public void OnFire(InputValue value)
    {
        // 只有按下时才触发
        if (!value.isPressed || aCopier == null) return;

        Camera cam = Camera.main;
        if (cam == null) return;

        // 1) 实例化
        Vector3 spawnPos =
    transform.position                  // 玩家胶囊的中心
    + Vector3.up * 1.0f                 // 抬到胸口高度（可调）
    + cam.transform.forward * spawnDistance;  // 在玩家前方一点

        Quaternion spawnRot = Quaternion.LookRotation(cam.transform.forward, Vector3.up);
        GameObject proj = Instantiate(aCopier, spawnPos, spawnRot);

        // 2) 确保有刚体
        Rigidbody rb = proj.GetComponent<Rigidbody>();
        if (rb == null) rb = proj.AddComponent<Rigidbody>();

        // 3) 可选：忽略与玩家的首次碰撞
        if (ignoreInitialCollision)
        {
            var projCol = proj.GetComponent<Collider>();
            var myCol = GetComponent<Collider>() ?? GetComponentInChildren<Collider>();
            if (projCol != null && myCol != null)
                Physics.IgnoreCollision(projCol, myCol, true);
        }

        // 4) 沿相机前方发射
        rb.AddForce(cam.transform.forward * launchForce, ForceMode.Impulse);

        // 5) 若需要：一段时间后自动删除
        if (lifeTime > 0f) Destroy(proj, lifeTime);
    }
}
