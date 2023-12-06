using UnityEngine;
using UnityEngine.InputSystem;
public class BulletShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;
    private Rigidbody shooterRigidBody;
    private void Start()
    {
        shooterRigidBody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // プレイヤー(Sphere)の向きを取得する
            Vector3 movingDirection = shooterRigidBody.velocity.normalized;
            // 弾のインスタンスを生成し、位置と回転をシューターと同じに設定します。
            var bulletInstance = Instantiate(bulletPrefab, transform.position + movingDirection * 1.5f, transform.rotation);
            // 弾に前方向に速度を加えます。
            var bulletRigidBody = bulletInstance.GetComponent<Rigidbody>();
            if (bulletRigidBody != null)
            {
                bulletRigidBody.velocity = movingDirection * bulletSpeed;
            }
        }
    }
}