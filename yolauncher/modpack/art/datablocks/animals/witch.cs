/**
* <author>Warped ibun & Kurai Sereph</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>Witches from mmo introduced to Lif:YO using grouse</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/
datablock AnimalData(WitchData : DefaultPlayerData)
{
    id = 752; // has to be globally unique currently this replaces the bear id
    animalTypeId = 751;
    footprintTexture = "art/Textures/AnimalFootprints/Wolf_fs.png";
    footprintTextureLinearSize = 0.4;
    footprintGap = 0.6;
    footprintTrackWidth = 0.4;
    shapeFile = "yolauncher/modpack/art/models/3d/mobiles/wildanimals/Tribe_Witch.dts"; // reference this to yolauncher modpack in order for client to work
    soundFilesPrefix = "wolf";
    behavior = "yolauncher/modpack/data/ai/Tribe_Witch.xml"; // reference this to yolauncher modpack for client to work
    boundingBox = "1 2.4 1.8";
    runSurfaceAngle = 50;
    maxHP = 250;
    bodyRadius = 2.5;
    rawCorpseObjectTypeID = 2007;
    skinnedCorpseObjectTypeID = 928;
    WeaponData = "Wolf_Fang";
    weaponWeight = 12;
    powerHitStartingDistance = 1.2;
    powerHitDamagingDistance = 1.4;
    powerHitDamagingSector = 90;
    powerHitMinSpeed = 15;
    powerHitMaxSpeed = 25;
    fastHitStartingDistance = 1.2;
    fastHitDamagingDistance = 1.4;
    fastHitDamagingSector = 90;
    fastHitMinSpeed = 5;
    fastHitMaxSpeed = 12;
    walkAnimationSpeed = 1.72;
    runAnimationSpeed = 1.21;
    walkSpeed = 3;
    runSpeed = 9;
    animalType = "Predator";
};

