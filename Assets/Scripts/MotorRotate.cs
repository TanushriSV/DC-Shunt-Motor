using UnityEngine;

public class MotorRotate : MonoBehaviour
{
    public float currentRPM;

    void Update()
    {
        float rotationPerSecond =
            currentRPM * 6f;

        transform.Rotate(
            Vector3.forward,
            rotationPerSecond * Time.deltaTime);
    }
}