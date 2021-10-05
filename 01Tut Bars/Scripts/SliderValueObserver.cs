namespace VGDevs.Examples
{
    using UnityEngine;
    using UnityEngine.UI;

    public class SliderValueObserver : MonoBehaviour
    {
        [SerializeField] private FloatVariable m_variable;
        [SerializeField] private Slider m_slider;

        private void UpdateVariable()
        {
            m_slider.value = m_variable.Value;
        }
        
        private void Start()
        {
            m_variable.OnChange += UpdateVariable;
        }

        private void OnDestroy()
        {
            m_variable.OnChange -= UpdateVariable;
        }
    }
}