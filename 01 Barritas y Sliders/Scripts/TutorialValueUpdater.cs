using System;
using System.Collections;

namespace VGDevs.Examples
{
    using TMPro;
    using UnityEngine;

    public class TutorialValueUpdater : MonoBehaviour
    {
        [SerializeField] private FloatVariable m_playerHealth;
        [SerializeField] private IntVariable m_playerCurrency;

        [SerializeField] private float m_healthMultiplier = 1f;
        [SerializeField] private Vector2Int m_currencySumRange = new Vector2Int(1, 100);
        [SerializeField] private float m_currencyUpdateTimer = 1f;

        private void Start()
        {
            StartCoroutine(UpdateCurrency());
        }

        private void Update()
        {
            UpdateHealth();
        }

        private void UpdateHealth()
        {
            if (m_playerHealth == null)
            {
                Debug.LogError($"'TutorialValueUpdater' needs a health object to work :D please add them to the '{gameObject.name}' object in the scene.");
                return;
            }
            
            if (m_playerHealth.Value > 100f)
            {
                m_playerHealth.Value = 0f;
            }

            m_playerHealth.Value += Time.deltaTime * m_healthMultiplier;
        }

        private IEnumerator UpdateCurrency()
        {
            while (true)
            {
                if (m_playerCurrency == null)
                {
                    Debug.LogError($"'TutorialValueUpdater' needs a currency object to work :D please add them to the '{gameObject.name}' object in the scene.");
                    yield return null;
                }
            
                if (m_playerCurrency.Value > 10000)
                {
                    m_playerCurrency.Value = 0;
                }

                m_playerCurrency.Value += Random.Range(m_currencySumRange.x, m_currencySumRange.y);

                yield return new WaitForSecondsRealtime(m_currencyUpdateTimer);
            }
        }

        private void OnDestroy()
        {
            StopCoroutine(UpdateCurrency());
        }

        public void SumRandomCurrency()
        {
            m_playerCurrency.Value += Random.Range(m_currencySumRange.x, m_currencySumRange.y);
        }
    }
}