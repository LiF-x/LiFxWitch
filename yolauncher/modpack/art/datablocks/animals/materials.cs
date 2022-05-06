/**
* <author>Warped ibun & Kurai Sereph</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>Witches from mmo introduced to Lif:YO using grouse</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

singleton Material(Tribe_Witch_Redreaper_DIFFUSE)
{
    mapTo = "Tribe_Witch_Redreaper_DIFFUSE";
    diffuseMap[0] = "yolauncher/modpack/art/Textures/Tribal/Tribe_Witch_Redreaper_DIFFUSE.dds";
    diffuseMap[1] = "yolauncher/modpack/art/Textures/Tribal/Tribe_Witch_Redreaper_NORMALMAP.dds";
    diffuseMap[2] = "yolauncher/modpack/art/Textures/Tribal/Tribe_Witch_Redreaper_SPECULAR.dds";
    alphaTest = "1";
    doubleSided = "1";
    translucent = "0";
    alphaRef = "35";
    isHair = true;
    materialTag0 = "LiF";
    mipLODBias = -1.2;
    useAnisotropic[0] = "1";
    translucentZWrite = "1";
    skinned = true;
};

singleton Material(Tribe_Weapon_DIFFUSE)
{
    mapTo = "Tribe_Weapon_DIFFUSE";
    diffuseMap[0] = "yolauncher/modpack/art/Textures/Tribal/Tribe_Weapon_DIFFUSE.dds";
    diffuseMap[1] = "yolauncher/modpack/art/Textures/Tribal/Tribe_Weapon_NORMALMAP.dds";
    diffuseMap[2] = "yolauncher/modpack/art/Textures/Tribal/Tribe_Weapon_SPECULAR.dds";
    alphaTest = "1";
    doubleSided = "1";
    translucent = "0";
    alphaRef = "35";
    isHair = true;
    materialTag0 = "LiF";
    mipLODBias = -1.2;
    useAnisotropic[0] = "1";
    translucentZWrite = "1";
    skinned = true;
};

