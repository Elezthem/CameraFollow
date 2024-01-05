using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // Ссылка на объект, за которым будет следить камера
    public float smoothSpeed = 0.125f;  // Плавность следования

    void LateUpdate()
    {
        if (target != null)
        {
            // Получаем текущую позицию камеры
            Vector3 desiredPosition = new Vector3(target.position.x, transform.position.y, transform.position.z);

            // Плавно перемещаем камеру к новой позиции
            transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        }
    }
}
