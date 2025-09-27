using UnityEngine;
using UnityEngine.UI;

public class FloatingHealthbar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Camera camera1;
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;
    
    public void UpdateHealthBar(float currentValue, float maxValue)
    {
        slider.value = currentValue / maxValue;
    }
    void Update()
    {
       transform.rotation = camera1.transform.rotation;
       transform.position = target.position + offset;
    }
}
