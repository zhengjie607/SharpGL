using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template
{
    public class Materials
    {
        public Materials(Material m)
        {
            ambient_light = new float[4];
            diffuse = new float[4];
            specular = new float[4];
            switch (m)
            {
                case Material.brass:
                    ambient_light[0] = 0.329412f;
                    ambient_light[1] = 0.223529f;
                    ambient_light[2] = 0.027451f;
                    ambient_light[3] = 1.000000f;
                    diffuse[0] = 0.780392f;
                    diffuse[1] = 0.568627f;
                    diffuse[2] = 0.113725f;
                    diffuse[3] = 1.000000f;
                    specular[0] = 0.992157f;
                    specular[1] = 0.941176f;
                    specular[2] = 0.807843f;
                    specular[3] = 1.000000f;
                    shininess = 27.897400f;
                    break;
                case Material.bronze:
                    ambient_light[0] = 0.212500f;
                    ambient_light[1] = 0.127500f;
                    ambient_light[2] = 0.054000f;
                    ambient_light[3] = 1.000000f;
                    diffuse[0] = 0.714000f;
                    diffuse[1] = 0.428400f;
                    diffuse[2] = 0.181440f;
                    diffuse[3] = 1.000000f;
                    specular[0] = 0.393548f;
                    specular[1] = 0.271906f;
                    specular[2] = 0.166721f;
                    specular[3] = 1.000000f;
                    shininess = 25.600000f;
                    break;
                case Material.brightbronze:
                    ambient_light[0] = 0.250000f;
                    ambient_light[1] = 0.148000f;
                    ambient_light[2] = 0.064750f;
                    ambient_light[3] = 1.000000f;
                    diffuse[0] = 0.400000f;
                    diffuse[1] = 0.236800f;
                    diffuse[2] = 0.103600f;
                    diffuse[3] = 1.000000f;
                    specular[0] = 0.774597f;
                    specular[1] = 0.458561f;
                    specular[2] = 0.200621f;
                    specular[3] = 1.000000f;
                    shininess = 76.800003f;
                    break;
                case Material.chromium:
                    ambient_light[0] = 0.250000f;
                    ambient_light[1] = 0.250000f;
                    ambient_light[2] = 0.250000f;
                    ambient_light[3] = 1.000000f;
                    diffuse[0] = 0.400000f;
                    diffuse[1] = 0.400000f;
                    diffuse[2] = 0.400000f;
                    diffuse[3] = 1.000000f;
                    specular[0] = 0.774597f;
                    specular[1] = 0.774597f;
                    specular[2] = 0.774597f;
                    specular[3] = 1.000000f;
                    shininess = 76.800003f;
                    break;
                case Material.copper:
                    ambient_light[0] = 0.191250f;
                    ambient_light[1] = 0.073500f;
                    ambient_light[2] = 0.022500f;
                    ambient_light[3] = 1.000000f;
                    diffuse[0] = 0.703800f;
                    diffuse[1] = 0.270480f;
                    diffuse[2] = 0.082800f;
                    diffuse[3] = 1.000000f;
                    specular[0] = 0.256777f;
                    specular[1] = 0.137622f;
                    specular[2] = 0.086014f;
                    specular[3] = 1.000000f;
                    shininess = 12.800000f;
                    break;
                case Material.brightcopper:
                    ambient_light[0] = 0.229500f;
                    ambient_light[1] = 0.088250f;
                    ambient_light[2] = 0.027500f;
                    ambient_light[3] = 1.000000f;
                    diffuse[0] = 0.550800f;
                    diffuse[1] = 0.211800f;
                    diffuse[2] = 0.066000f;
                    diffuse[3] = 1.000000f;
                    specular[0] = 0.580594f;
                    specular[1] = 0.223257f;
                    specular[2] = 0.069570f;
                    specular[3] = 1.000000f;
                    shininess = 51.200001f;
                    break;
                case Material.gold:
                    ambient_light[0] = 0.247250f;
                    ambient_light[1] = 0.199500f;
                    ambient_light[2] = 0.074500f;
                    ambient_light[3] = 1.000000f;
                    diffuse[0] = 0.751640f;
                    diffuse[1] = 0.606480f;
                    diffuse[2] = 0.226480f;
                    diffuse[3] = 1.000000f;
                    specular[0] = 0.628281f;
                    specular[1] = 0.555802f;
                    specular[2] = 0.366065f;
                    specular[3] = 1.000000f;
                    shininess = 51.200001f;
                    break;
                case Material.brightgold:
                    ambient_light[0] = 0.247250f;
                    ambient_light[1] = 0.224500f;
                    ambient_light[2] = 0.064500f;
                    ambient_light[3] = 1.000000f;
                    diffuse[0] = 0.346150f;
                    diffuse[1] = 0.314300f;
                    diffuse[2] = 0.090300f;
                    diffuse[3] = 1.000000f;
                    specular[0] = 0.797357f;
                    specular[1] = 0.723991f;
                    specular[2] = 0.208006f;
                    specular[3] = 1.000000f;
                    shininess = 83.199997f;
                    break;
                case Material.whitewax:
                    ambient_light[0] = 0.105882f;
                    ambient_light[1] = 0.058824f;
                    ambient_light[2] = 0.113725f;
                    ambient_light[3] = 1.000000f;
                    diffuse[0] = 0.427451f;
                    diffuse[1] = 0.470588f;
                    diffuse[2] = 0.541176f;
                    diffuse[3] = 1.000000f;
                    specular[0] = 0.333333f;
                    specular[1] = 0.333333f;
                    specular[2] = 0.521569f;
                    specular[3] = 1.000000f;
                    shininess = 9.846150f;
                    break;
                case Material.silver:
                    ambient_light[0] = 0.192250f;
                    ambient_light[1] = 0.192250f;
                    ambient_light[2] = 0.192250f;
                    ambient_light[3] = 1.000000f;
                    diffuse[0] = 0.507540f;
                    diffuse[1] = 0.507540f;
                    diffuse[2] = 0.507540f;
                    diffuse[3] = 1.000000f;
                    specular[0] = 0.508273f;
                    specular[1] = 0.508273f;
                    specular[2] = 0.508273f;
                    specular[3] = 1.000000f;
                    shininess = 51.200001f;
                    break;
                case Material.brightsilver:
                    ambient_light[0] = 0.231250f;
                    ambient_light[1] = 0.231250f;
                    ambient_light[2] = 0.231250f;
                    ambient_light[3] = 1.000000f;
                    diffuse[0] = 0.277500f;
                    diffuse[1] = 0.277500f;
                    diffuse[2] = 0.277500f;
                    diffuse[3] = 1.000000f;
                    specular[0] = 0.773911f;
                    specular[1] = 0.773911f;
                    specular[2] = 0.773911f;
                    specular[3] = 1.000000f;
                    shininess = 89.599998f;
                    break;
                case Material.emerald:
                    ambient_light[0] = 0.021500f;
                    ambient_light[1] = 0.174500f;
                    ambient_light[2] = 0.021500f;
                    ambient_light[3] = 0.550000f;
                    diffuse[0] = 0.075680f;
                    diffuse[1] = 0.614240f;
                    diffuse[2] = 0.075680f;
                    diffuse[3] = 0.550000f;
                    specular[0] = 0.633000f;
                    specular[1] = 0.727811f;
                    specular[2] = 0.633000f;
                    specular[3] = 0.550000f;
                    shininess = 76.800003f;
                    break;
                case Material.jasper:
                    ambient_light[0] = 0.135000f;
                    ambient_light[1] = 0.222500f;
                    ambient_light[2] = 0.157500f;
                    ambient_light[3] = 0.950000f;
                    diffuse[0] = 0.540000f;
                    diffuse[1] = 0.890000f;
                    diffuse[2] = 0.630000f;
                    diffuse[3] = 0.950000f;
                    specular[0] = 0.316228f;
                    specular[1] = 0.316228f;
                    specular[2] = 0.316228f;
                    specular[3] = 0.950000f;
                    shininess = 12.800000f;
                    break;
                case Material.obsidian:
                    ambient_light[0] = 0.053750f;
                    ambient_light[1] = 0.050000f;
                    ambient_light[2] = 0.066250f;
                    ambient_light[3] = 0.820000f;
                    diffuse[0] = 0.182750f;
                    diffuse[1] = 0.170000f;
                    diffuse[2] = 0.225250f;
                    diffuse[3] = 0.820000f;
                    specular[0] = 0.332741f;
                    specular[1] = 0.328634f;
                    specular[2] = 0.346435f;
                    specular[3] = 0.820000f;
                    shininess = 38.400002f;
                    break;
                case Material.pearl:
                    ambient_light[0] = 0.250000f;
                    ambient_light[1] = 0.207250f;
                    ambient_light[2] = 0.207250f;
                    ambient_light[3] = 0.922000f;
                    diffuse[0] = 1.000000f;
                    diffuse[1] = 0.829000f;
                    diffuse[2] = 0.829000f;
                    diffuse[3] = 0.922000f;
                    specular[0] = 0.296648f;
                    specular[1] = 0.296648f;
                    specular[2] = 0.296648f;
                    specular[3] = 0.922000f;
                    shininess = 11.264000f;
                    break;
                case Material.ruby:
                    ambient_light[0] = 0.174500f;
                    ambient_light[1] = 0.011750f;
                    ambient_light[2] = 0.011750f;
                    ambient_light[3] = 0.550000f;
                    diffuse[0] = 0.614240f;
                    diffuse[1] = 0.041360f;
                    diffuse[2] = 0.041360f;
                    diffuse[3] = 0.550000f;
                    specular[0] = 0.727811f;
                    specular[1] = 0.626959f;
                    specular[2] = 0.626959f;
                    specular[3] = 0.550000f;
                    shininess = 76.800003f;
                    break;
                case Material.beryl:
                    ambient_light[0] = 0.100000f;
                    ambient_light[1] = 0.187250f;
                    ambient_light[2] = 0.174500f;
                    ambient_light[3] = 0.800000f;
                    diffuse[0] = 0.396000f;
                    diffuse[1] = 0.741510f;
                    diffuse[2] = 0.691020f;
                    diffuse[3] = 0.800000f;
                    specular[0] = 0.297254f;
                    specular[1] = 0.308290f;
                    specular[2] = 0.306678f;
                    specular[3] = 0.800000f;
                    shininess = 12.800000f;
                    break;
                case Material.blackplastic:
                    ambient_light[0] = 0.000000f;
                    ambient_light[1] = 0.000000f;
                    ambient_light[2] = 0.000000f;
                    ambient_light[3] = 1.000000f;
                    diffuse[0] = 0.010000f;
                    diffuse[1] = 0.010000f;
                    diffuse[2] = 0.010000f;
                    diffuse[3] = 1.000000f;
                    specular[0] = 0.500000f;
                    specular[1] = 0.500000f;
                    specular[2] = 0.500000f;
                    specular[3] = 1.000000f;
                    shininess = 32.000000f;
                    break;
                case Material.blackrubber:
                    ambient_light[0] = 0.020000f;
                    ambient_light[1] = 0.020000f;
                    ambient_light[2] = 0.020000f;
                    ambient_light[3] = 1.000000f;
                    diffuse[0] = 0.010000f;
                    diffuse[1] = 0.010000f;
                    diffuse[2] = 0.010000f;
                    diffuse[3] = 1.000000f;
                    specular[0] = 0.400000f;
                    specular[1] = 0.400000f;
                    specular[2] = 0.400000f;
                    specular[3] = 1.000000f;
                    shininess = 10.000000f;
                    break;
                case Material.violet:
                    ambient_light[0] = 0.110000f;
                    ambient_light[1] = 0.060000f;
                    ambient_light[2] = 0.090000f;
                    ambient_light[3] = 1.000000f;
                    diffuse[0] = 0.430000f;
                    diffuse[1] = 0.470000f;
                    diffuse[2] = 0.540000f;
                    diffuse[3] = 1.000000f;
                    specular[0] = 0.330000f;
                    specular[1] = 0.330000f;
                    specular[2] = 0.520000f;
                    specular[3] = 1.000000f;
                    shininess = 22.000000f;
                    break;
            }
        }
        public float[] ambient_light;
        public float[] diffuse;
        public float[] specular;
        public float shininess;
    }
    public enum Material
    {
        brass,//黄铜
        bronze,//青铜
        brightbronze,//亮青铜
        chromium,//铬
        copper,//铜
        brightcopper,//亮铜
        gold,//金
        brightgold,//亮金
        whitewax,//白蜡
        silver,//银
        brightsilver,
        emerald,//翠绿
        jasper,//墨绿
        obsidian,//黑曜石
        pearl,//珍珠
        ruby,//红宝石
        beryl,//绿宝石
        blackplastic,//黑塑料
        blackrubber,//黑橡胶
        violet,//紫罗兰
    }
}
