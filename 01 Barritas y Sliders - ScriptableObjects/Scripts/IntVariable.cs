namespace VGDevs.Examples
{
    using System;
    using UnityEngine;
    
    public class IntVariable : ScriptableObject
    {
        [SerializeField] private int m_value;

        public Action OnChange;

        public int Value
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