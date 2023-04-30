using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Vandy.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class HeroicHelmet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Heroic Helmet"); 
			Tooltip.SetDefault("5% increased melee damage");
		}

		public override void SetDefaults() 
		{
			item.width = 20;
			item.height = 20;
			item.value = 7500;
			item.rare = 2;
			item.defense = 13;
		}

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
			return body.type == mod.ItemType("HeroicChestplate") && legs.type == mod.ItemType("HeroicLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {
			player.setBonus = "20% increased movement speed";
			player.moveSpeed += 0.20f;
        }

        public override void UpdateEquip(Player player)
        {
			player.meleeDamage += 0.05f;
        }

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldIngots, 25);
			recipe.AddIngredient(ItemID.SilverIngots, 25);
			recipe.AddIngredient(ItemID.DemoniteIngots, 35);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}