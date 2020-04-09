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
    class SteelArrowProjectile : ModProjectile
    { 

        public override void SetDefauls()
        { 
    
           

            projectile.width = 7;
            projectile.height = 19;

            projectile.aiStyle = 1;

            projectile.friendly = true;

            projectile.penetrate = 2;

            projectile.ranged = true;

            projectile.tileCollide = true;

            projectile.ignoreWater = true;

            projectile.arrow = true;
        }


    public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("ExampleSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            DisplayName.SetDefault("Steel Arrow");
        }
        
        
        public override void Kill(int timeLeft)
        {
            if (projectile.owner == Main.myPlayer)
            {
                int item = Main.rand.NextBool(3) ? Item.NewItem(projectile.getRect(), mod.ItemType("SteelArrow")) : 0;
            }
        }
    }
}