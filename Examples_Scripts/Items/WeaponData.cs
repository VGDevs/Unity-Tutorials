using System;
using System.Collections.Generic;
using UnityEngine;

namespace VGDevs
{
	[CreateAssetMenu( menuName = VGDevs.kCreateMenuPrefixName + "Game/Item - Weapon")]
	public class WeaponData : BaseItemData
	{
		[Header("Weapon Config")]
		public Damage Damage;
		public List<Damage> ExtraDamages;
		public int Durability;
		
		public WeaponType WeaponType;
		public WeaponFlags WeaponFlags;
	}

	[System.Flags]
	public enum WeaponType
	{
		Melee, Ranged, Siege
	}

	[System.Flags]
	public enum WeaponFlags
	{
		MainHand, Offhand, OneHand, TwoHanded,
	}

	[Serializable]
	public class Damage
	{
		public int Min;
		public int Max;
		public DamageType Type;

		public int Value => GetCalculatedDamage();

		private int GetCalculatedDamage()
		{
			return UnityEngine.Random.Range(Min, Max);
		}
	}
	
	[Serializable]
	public enum DamageType
	{
		None = 0,
		Physical,
		Magical,
		Piercing,
		Bludgeoning,
	}
}