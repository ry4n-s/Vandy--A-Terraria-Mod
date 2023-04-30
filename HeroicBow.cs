using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Vandy.Items
{
	public class HeroicBow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Heroic Bow"); 
			Tooltip.SetDefault("Effective, powerful bow");
		}


        public override void SetDefaults() 
		{
			item.damage = 20;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 32;
			item.useAnimation = 32;
			item.useStyle = 5;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 1; 
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.useAmmo = AmmoID.Arrow;
			item.shootSpeed = 6.25f;
			item.noMelee = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldIngots, 10);
			recipe.AddIngredient(ItemID.SilverIngots, 10);
			recipe.AddIngredient(ItemID.DemoniteIngots, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override Vector2? HoldoutOffset()
        {
			Vector2 offset = new Vector2(6,0);
			return offset;
        }

    }
}