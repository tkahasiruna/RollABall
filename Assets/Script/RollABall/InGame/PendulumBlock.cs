using UnityEngine;

public class PendulumBlock : MonoBehaviour
{
    public float Amplitude = 5f; //�U��
    public float Frequency = 1f; //�p�x
    private Vector3 startPos = Vector3.zero;
    private void Start()
    {
        startPos = transform.position;
    }
    void Update()
    {
        transform.position = startPos + Vector3.forward * Amplitude * Mathf.Sin(Time.time * Frequency);
    }
}