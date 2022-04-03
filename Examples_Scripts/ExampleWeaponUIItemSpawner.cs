﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VGDevs
{
	public class ExampleWeaponUIItemSpawner : MonoBehaviour
	{
		// This is an example of the "Access" usage.
		//[SerializeField] private WeaponUIItem m_prefab => VGDevs.Prefabs.WeaponUIItem;
		[SerializeField] private WeaponUIItem m_prefab;

		[SerializeField] private ItemDataCollection m_allItemDefinitionsInProject;

		// This is an example of a direct reference usage, see this is scene independent.
		[SerializeField] private WeaponUIItemCollection m_storedCollectionOfBuiltItems;

		// just a container for the instantiating.
		[SerializeField] private RectTransform m_holder;

		public void Start()
		{
			BuildDemoItems();
		}

		private void BuildDemoItems()
		{
			for (int x = -2; x < 2; x++)
			{
				for (int y = -2; y < 2; y++)
				{
					WeaponUIItem newItem = Instantiate(m_prefab, new Vector3(x, y, 0f), Quaternion.identity, m_holder);

					WeaponData randomItemData = m_allItemDefinitionsInProject.GetRandom() as WeaponData;
					newItem.Build(randomItemData);

					m_storedCollectionOfBuiltItems.List.Add(newItem);
				}
			}
		}
	}
}