using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Vandy.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class HeroicChestplate : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Heroic Chestpiece"); 
			Tooltip.SetDefault("5% increased critical strike chance");
		}

		public override void SetDefaults() 
		{
			item.width = 20;
			item.height = 20;
			item.value = 10000;
			item.rare = 2;
			item.defense = 18;
		}

        public override void UpdateEquip(Player player)
        {
			player.meleeCrit += 5;
			player.magicCrit += 5;
			player.rangedCrit += 5;
			player.thrownCrit += 5;
        }

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldIngots, 35);
			recipe.AddIngredient(ItemID.SilverIngots, 35);
			recipe.AddIngredient(ItemID.DemoniteIngots, 35);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}