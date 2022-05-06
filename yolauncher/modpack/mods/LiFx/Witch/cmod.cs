/**
* <author>Warped ibun & Kurai Sereph</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>Witches from mmo introduced to Lif:YO using grouse</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxWitch))
{
    new ScriptObject(LiFxWitch)
    {
    };
}
package LiFxWitch
{
  function LiFxWitch::setup() {
    LiFx::registerCallback($LiFx::hooks::onDatablockLoad, RegisterDatablock, LiFxWitch);
    LiFx::registerCallback($LiFx::hooks::onMaterialsLoad, RegisterMaterials, LiFxWitch);
  }

  function LiFxWitch::RegisterDatablock() {
      LiFx::loadRecursivelyInFolder("yolauncher/modpack/art/datablocks", "witch.cs");
  }
  function LiFxWitch::RegisterMaterials() {
    LiFx::loadRecursivelyInFolder("yolauncher/modpack", "materials.cs");
  }
};
activatePackage(LiFxWitch);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxWitch);