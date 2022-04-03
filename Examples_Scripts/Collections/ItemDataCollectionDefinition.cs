using System.Collections.Generic;

namespace VGDevs
{
    public class ItemDataCollectionDefinition<T> : BaseCollection<T> where T : BaseItemData
    {
        /// <summary>
        /// Get all Items by ItemType.
        /// </summary>
        /// <param name="itemType"></param>
        /// <returns></returns>
        public List<T> GetAllByType(ItemType itemType)
        {
            return m_list.FindAll(x => x.Type == itemType);
        }
		
        /// <summary>
        /// Get all Items by Flags.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public List<T> GetAllByFlags(ItemFlags flag)
        {
            return m_list.FindAll(x => x.Flags.HasFlag(flag));
        }
    }
}