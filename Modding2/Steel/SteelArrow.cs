using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Modding2.Items
{
    class SteelArrow : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 7;
            item.height = 19;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1.2f;
            item.value = Item.sellPrice(copper: 50);
            item.rare = 1;

            item.shoot = mod.ProjectileType("SteelArrowProjectile");
            item.shootSpeed = 8.5f;
            item.ammo = AmmoID.Arrow;
        }
    }
}
