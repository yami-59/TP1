using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // 必须：指针事件接口

public class MouseCubeInteraction : MonoBehaviour,
    IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    // 可调参数
    [Header("Hover & Force")]
    public Color hoverColor = Color.yellow;   // 悬停时颜色
    public float pushForce = 8f;              // 点击推力（Impulse）

    // 缓存组件
    private Rigidbody m_rigidbody;
    private Renderer m_renderer;

    // 记录初始颜色
    private Color _initialColor;

    void Start()
    {
        // 拿到刚体与渲染器
        m_rigidbody = GetComponent<Rigidbody>();
        m_renderer = GetComponent<Renderer>();

        // 安全防御：若缺失组件，尝试补救或给出日志
        if (m_rigidbody == null)
        {
            m_rigidbody = gameObject.AddComponent<Rigidbody>();
            m_rigidbody.mass = 1f;
        }
        if (m_renderer == null)
        {
            Debug.LogWarning($"{name}: Renderer manquant.");
        }
        else
        {
            _initialColor = m_renderer.material.color;
        }
    }

    // 鼠标移入
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (m_renderer != null)
        {
            m_renderer.material.color = hoverColor;
        }
        Debug.Log($"{name}: souris survole (Enter).");
    }

    // 鼠标移出
    public void OnPointerExit(PointerEventData eventData)
    {
        if (m_renderer != null)
        {
            m_renderer.material.color = _initialColor;
        }
        Debug.Log($"{name}: souris quitte (Exit).");
    }

    // 鼠标按下（点击）
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log($"{name}: cliqué (Down).");

        if (m_rigidbody != null && Camera.main != null)
        {
            // 沿主摄像机正前方向给一个冲量
            Vector3 dir = Camera.main.transform.forward.normalized;
            m_rigidbody.AddForce(dir * pushForce, ForceMode.Impulse);
        }
    }
}

