namespace VGDevs.Examples
{
    using UnityEngine;

    [CreateAssetMenu(menuName = "VGDevs/Spells/BaseSpell")]
    public class BaseSpell : BaseAbility
    {
        [SerializeField] private BaseTarget m_target;

        public virtual void Cast()
        {
            
        }
    }
}