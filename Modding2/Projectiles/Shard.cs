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
    public class Shard : ModProjectile
    {
        public override void SetDefauls()
        {
            projectile.Name = "Shard";
            projectile.width = 18;
            projectile.height = 30;
            projectile.friendly = true;
            projectile.tileCollide = true;
            projectile.penetrate = 2;
            projectile.timeLeft = 600;
            projectile.light = 1f;
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
        }

    }
}