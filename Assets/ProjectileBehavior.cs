using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            // 删掉被击中的方块
            Destroy(collision.gameObject);

            // 找到 GameManager 并加分（更保险的写法）
            GameManager gm = GameManager.Instance ?? FindObjectOfType<GameManager>();
            if (gm != null)
            {
                gm.AddScore(1);
            }
            else
            {
                Debug.LogWarning("No GameManager found in scene when hitting Target.");
            }

            // 删掉子弹
            Destroy(gameObject);
        }

        // 撞到其他东西不处理（由 lifeTime 自动销毁）
    }
}
