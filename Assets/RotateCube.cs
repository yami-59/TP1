using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.InputSystem; // 新输入系统命名空间


public class RotateCube : MonoBehaviour
{
    public float rotationAngle = 180f;
    private bool isRotating = false;

    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(0f, rotationAngle * Time.deltaTime, 0f, Space.World);
        }
    }

    // ⚠️ 这个方法名、参数类型都必须和下面一模一样
    public void OnRotate(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            isRotating = !isRotating;
            Debug.Log($"R pressed → Rotation: {(isRotating ? "ON" : "OFF")}");
        }
    }
}

