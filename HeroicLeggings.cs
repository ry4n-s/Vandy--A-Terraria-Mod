using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Vandy.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class HeroicLeggings : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Heroic Pants"); 
			Tooltip.SetDefault("7% increased movement speed");
		}

		public override void SetDefaults() 
		{
			item.width = 20;
			item.height = 20;
			item.value = 9000;
			item.rare = 2;
			item.defense = 15;
		}

        public override void UpdateEquip(Player player)
        {
			player.moveSpeed += 0.07f;
        }

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldIngots, 25);
			recipe.AddIngredient(ItemID.SilverIngots, 25);
			recipe.AddIngredient(ItemID.DemoniteIngots, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
