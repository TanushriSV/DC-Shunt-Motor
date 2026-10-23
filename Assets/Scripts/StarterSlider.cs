using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StarterSlider : MonoBehaviour
{
    public Slider slider;

    public TMP_Text vaText;
    public TMP_Text ifText;
    public TMP_Text iaText;
    public MotorRotate motor;

    private void Start()
    {
        slider.onValueChanged
            .AddListener(UpdateValues);
    }

    void UpdateValues(float value)
    {
        if (!CircuitManager.Instance
            .circuitCompleted)
        {
            return;
        }

        float Va =
            Mathf.Lerp(
                0f,
                220f,
                value);

        float If =
            Mathf.Lerp(
                0f,
                1.5f,
                value);

        float Ia =
            Mathf.Lerp(
                0f,
                5f,
                value);

        float rpm =
        Mathf.Lerp(0f, 1500f, value);

        motor.currentRPM = rpm;

        vaText.text =
            Va.ToString("F1");

        ifText.text =
            If.ToString("F2");

        iaText.text =
            Ia.ToString("F2");
    }
}