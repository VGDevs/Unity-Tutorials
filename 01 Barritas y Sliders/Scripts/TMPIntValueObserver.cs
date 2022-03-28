namespace VGDevs.Examples
{
    using TMPro;
    using UnityEngine;

    public class TMPIntValueObserver : MonoBehaviour
    {
        [Header("String to replace: " + kReplaceableString)]
        [SerializeField] private string m_textToReplace;
        [SerializeField] private IntVariable m_variable;
        [SerializeField] private TMP_Text m_tmpText;

        private const string kReplaceableString = "{value}";
        
        private void UpdateVariable()
        {
            string newText = m_textToReplace.Replace(kReplaceableString, m_variable.Value.ToString());
            m_tmpText.text = newText;
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