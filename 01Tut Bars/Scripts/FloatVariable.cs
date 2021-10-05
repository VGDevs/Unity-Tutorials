namespace VGDevs.Examples
{
    using System;
    using UnityEngine;
    
    [CreateAssetMenu(menuName = "VGDevs/FloatVariable")]
    public class FloatVariable : ScriptableObject
    {
        [SerializeField] private float m_value;

        public Action OnChange;

        public float Value
        {
            get => m_value;
            set
            {
                OnChange?.Invoke();
                m_value = value;
            }
        }
    }
}