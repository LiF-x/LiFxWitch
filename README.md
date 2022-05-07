# LiFxWitch
Example with Knool Witch using yolauncher servermodpack and lifx framework

## Prerequisite
7-zip installed: https://www.7-zip.org/

## Build Server Modpack for YoLauncher
To build a zip file that includes all the client side required files for yolauncher, simply run the included [bat file](createModpack.bat) (requires 7-zip as is)
Upload the genereated zip file to yolauncher and activate it as a modpack.

## Install on server.

Upload both the [mods](mods) folder and the [yolauncher](yolauncher) to your server root directory, the mods reference the datablock from yolauncher folder to ensure it is the same as the one you made in the server modpack.


### Credits
- Kurai Seraph (for the method of making the mmo dts moveable in yo)
- Warped Ibun (for the Witch dts)

Made compatible with [Yo Launcher Servermodpack](https://yolauncher.app/documentation) and LiFx Client & Server framework by [LiF-x](https://www.lifxmod.com/)



### Datablock ids
id - Datablock name
If you see an error in your logs with "SimDataBlock::protectedSetId() - illegal datablock ID" it means you have selected an existing ID or you are out of bounds for ID range.

- 3 - DefaultPlayerData
- 400 - PlayerMaleData
- 401 - PlayerFemaleData
- 139 - CameraData
- 356 - PathCameraData
#### Animals
- 61 - DeerMale
- 67 - AurochsBull
- 116 - Bear
- 117 - Boar
- 118 - Sow
- 119 - WildHorse
- 140 - Grouse
- 141 - Hare
- 142 - Hind
- 143 - Wolf
- 145 - Mutton
- 146 - AurochsCow
### SoundFX
- 274 - horse_move_walk_naked
- 275 - horse_move_walk_armoured
- 276 - horse_move_trot_naked
- 277 - horse_move_trot_armoured
- 278 - horse_move_gallop_naked
- 279 - horse_move_gallop_armoured
- 280 - HumanAudio
- 1016 - revoke_ritual
- 1017 - horse_jump
- 1018 - horse_idle
- 1019 - horse_move_gallop_armoured_tremble
- 1022 - horse_climbing
- 1023 - horse_climbing_down

### Riding
- 350 - HorseRiding
- 351 - HorseRidingFemale
- 352 - HorseSimpleWarhorse
- 353 - HorseHardyWarhorse
- 354 - HorseSpiritedWarhorse
- 355 - HorseHeavyWarhorse
- 361 - HorseRoyalWarhorse
- 362 - HorseCourierHorse
- 620 - RidingMoose

### Harnessed
- 365 - HarnessedCourierHorse
- 621 - HarnessedRidingMoose
- 695 - HarnessedStallion
- 696 - HarnessedHorse
- 697 - HarnessedWarhorse
- 698 - HarnessedSpiritedWarhorse
- 699 - HarnessedHardyWarhorse


### ParticleEmitterData
- 63 - FireParticleLiF1Z
- 69 - LiFEmitterNodeData
- 77 - FireParticleLiF2Z
- 85 - SmokeParticleLiF2Z
- 86 - BloodEmitterLiF1Z
- 87 - BloodEmitterLiF2Z
- 88 - BloodEmitterLiF3Z
- 89 - BloodEmitterLiF4Z
- 91 - BloodParticleLiF1Z
- 92 - BloodParticleLiF2Z
- 93 - BloodParticleLiF3Z
- 94 - BloodParticleLiF4Z
- 95 - BloodParticleLiF5Z
- 96 - BloodParticleLiF6Z
- 97 - BloodParticleLiF7Z
- 98 - BloodParticleLiF8Z
- 99 - BloodParticleLiF9Z
- 100 - BloodParticleLiF10Z
- 101 - BloodParticleLiF11Z
- 102 - BloodParticleLiF12Z
- 103 - BloodParticleLiF13Z
- 104 - BloodParticleLiF14Z
- 105 - BloodParticleLiF15Z
- 112 - FireEmitterLiF1Z
- 113 - FireEmitterLiF2Z
- 115 - SmokeEmitterLiF2Z
- 137 - TerFallParticleLiF
- 138 - TerFallEmitterLiF
- 150 - AudioMaster
- 151 - AudioChannelMaster
- 152 - AudioChannel
- 153 - AudioChannelDefault
- 154 - AudioChannelGui
- 155 - AudioChannelEffects
- 156 - AudioChannelMessages
- 157 - AudioChannelMusic
- 370 - Conflagration_fire_small_particle
- 371 - Conflagration_smoke_small_particle
- 372 - Conflagration_sparks_small_particle
- 376 - Conflagration_fire_medium_particle
- 377 - Conflagration_smoke_medium_particle
- 378 - Conflagration_sparks_medium_particle
- 384 - snowball_dust_particle
- 385 - snowball_element_particle
- 386 - spark_star
- 387 - spark_star_particle
- 391 - cow_blood_particle
- 392 - cow_dust_particle
- 393 - cow_meat_element_particle
- 397 - Watchfire_particle
- 398 - Watchfire_smoke_particle
- 399 - Watchfire_sparks_particle
- 402 - Stove_fire_particle
- 403 - Stove_smoke_particle
- 404 - Stove_sparks_particle
- 408 - Dust_for_tunnel_particle
- 409 - Dust_for_tunnel_elements_particle
- 412 - Dust_from_digging_particle
- 413 - Dust_from_digging_elements_particle
- 416 - Dust_from_walk_horse_particle
- 418 - Dust_from_walk_human_particle
- 420 - Motes_particle
- 422 - Dust_from_blow_particle
- 424 - Universal_dust_particle
- 426 - Sawdust_particle
- 428 - Scobs_particle
- 430 - Stone_fragments_particle
- 432 - flying_leaves_particle
- 433 - flying_dust_particle
- 436 - blood_test_A_particle
- 438 - blood_test_B_particle
- 440 - plough_dust_particle
- 441 - plough_dirt_elements_particle
- 442 - plough_dirt_elements_particle_2
- 447 - Stove_small_fire_particle
- 448 - big_weapon_smoke_particle
- 449 - big_weapon_smoke
- 450 - FireOfTorchParticle
- 452 - SparksOfTorchParticle
- 453 - FireOfTorchEmitter
- 455 - SparksOfTorchEmitter
- 456 - Explosion_elements_of_dirt_particle
- 457 - Explosion_smoke_particle
- 458 - Explosion_fire_particle
- 459 - Explosion_elements_of_dirt_small_particle
- 460 - Explosion_fire_small_particle
- 461 - Explosion_smoke_small_particle
- 462 - Explosion_elements_of_dirt
- 463 - Explosion_smoke
- 464 - Explosion_fire
- 465 - Explosion_elements_of_dirt_small
- 466 - Explosion_fire_small
- 467 - Explosion_smoke_small
- 468 - Building_destruction_dust1_particle
- 469 - Building_destruction_dust1
- 470 - Building_destruction_dust2_particle
- 471 - Building_destruction_dust2
- 472 - Building_destruction_element_particle
- 473 - Building_destruction_element
- 474 - Dust_from_building_construction_particle
- 475 - Dust_from_building_construction
- 476 - Grass_by_cut_plants_particle
- 477 - Leaves_by_falling_tree_particle
- 478 - Dust_by_falling_tree_particle
- 481 - Conflagration_fire_big_particle
- 482 - Conflagration_smoke_big_particle
- 483 - Conflagration_sparks_big_particle
- 487 - Furnace_smoke_particle
- 488 - Furnace_sparks_particle
- 489 - Campfire_big_smoke_particle
- 490 - Campfire_particle
- 502 - weapon_smoke
- 503 - weapon_smoke_particle
- 593 - TestFireEmitter
- 594 - TestAnimatedBillboard
- 598 - PowderKeg_smoke1_particle
- 599 - PowderKeg_smoke2_particle
- 600 - PowderKeg_sparks_particle
- 603 - sparks1_from_blow_metal_particle
- 604 - sparks2_from_blow_metal_particle
- 607 - flinders1_from_blow_particle
- 608 - flinders2_from_blow_particle
- 610 - Haloween_Trophy_fire_particle
- 613 - RevokingRitualParticle

### NPC
- 710 - NPC_slave_A
- 711 - NPC_slave_B
- 712 - NPC_slave_C
- 713 - NPC_slave_D
- 714 - NPC_slave_E
- 715 - NPC_slave_Overseer
- 780 - LiFx Knool Witch
- 781 - LiFx Knool Mole
- 782 - LiFx Knool Hunter
- 783 - LiFx Knool Bear
- 784 - LiFx Knool Chieftain

### Transport
- 689 - MountedPlough
- 690 - MountedWheelbarrow
- 691 - MountedCart
- 692 - MountedTrader_cart
- 694 - HarnessedHorseCart
- 701 - HarnessedHorseCartNoTent

### Weapons
- 4 - PracticeSword
- 5 - NordicSword
- 6 - KnightSword
- 7 - LightSaber
- 8 - Scimitar
- 9 - Falchion
- 10 - PracticeBastard
- 11 - Estoc
- 12 - BastardSword
- 13 - BigFalchion
- 14 - GrossMesser
- 15 - PracticeAxe
- 16 - WarAxe
- 17 - BattleAxe
- 18 - NordicAxe
- 19 - MorningStar
- 20 - FlangedMace
- 21 - Cudgel
- 22 - WarPick
- 23 - PracticeLongsword
- 24 - Claymore
- 25 - Zweihaender
- 26 - Flamberge
- 27 - PracticeGreataxe
- 28 - Pollaxe
- 29 - Bardiche
- 30 - BroadAxe
- 31 - SledgeHammer
- 32 - Maul
- 33 - PracticeMaul
- 34 - Glaive
- 35 - Guisarme
- 36 - WarScythe
- 37 - Pitchfork
- 38 - Partisan
- 39 - Staff
- 40 - Spear
- 41 - BoarSpear
- 42 - AwlPike
- 43 - BecdeCorbin
- 44 - ShortPike
- 45 - MediumPike
- 46 - LongPike
- 47 - Lance
- 48 - JoustingLance
- 49 - SimpleBow
- 50 - ShortBow
- 51 - LongBow
- 52 - CompositeBow
- 53 - LightCrossbow
- 54 - Arbalest
- 55 - HeavyCrossbow
- 56 - Sling
- 70 - TargeShield
- 71 - PrimitiveShield
- 72 - BucklerShield
- 73 - HeaterShield
- 74 - KiteShield
- 75 - TowerShield
- 76 - PaviseShield
- 120 - Shovel
- 121 - Primitive_shovel
- 122 - Primitive_pickaxe
- 123 - Pickaxe
- 124 - Hardened_steel_pickaxe
- 125 - Primitive_hammer
- 126 - Smiths_Hammer
- 127 - Mallet
- 128 - Fishing_Pole
- 129 - Primitive_Axe
- 130 - Hatchet
- 131 - Primitive_Saw
- 132 - Saw
- 133 - Primitive_CrucibleandStick
- 134 - CrucibleandTongs
- 135 - Primitive_Sickle
- 136 - Sickle
- 147 - IronRoundShield
- 319 - Primitive_Cooking_Pot
- 320 - Cooking_Pot
- 321 - Primitive_Knife
- 322 - Knife
- 323 - Skinning_knife
- 324 - Glassblower_toolkit
- 325 - Bear_Paw
- 326 - Wild_Horse_Hoof
- 327 - Deer_Hoof
- 328 - Hind_Hoof
- 329 - Wolf_Fang
- 330 - Moose_Hoof
- 331 - Boar_Tusk
- 332 - Sow_Tusk
- 333 - Mutton_Horns
- 334 - Bull_Horns
- 335 - Cow_Horns
- 336 - Primitive_Fishing_Pole
- 337 - Torch
- 338 - DecoratedJoustingLance
- 340 - TrebuchetData
- 341 - SiegeStoneAmmo
- 342 - SiegeStoneAmmoLoaded
- 343 - BarrelAmmo
- 344 - BarrelAmmoLoaded
- 345 - ThrowingPot
- 346 - ThrowingPotProjectile
- 357 - ExplosionBomb_1151
- 363 - NapthaBarrelAmmo
- 364 - NapthaBarrelAmmoLoaded
- 366 - CowAmmo
- 367 - CowAmmoLoaded
- 368 - Snowball
- 369 - SnowballProjectile
- 559 - BodkinArrow
- 560 - BodkinArrowLoaded
- 561 - BroadheadArrow
- 562 - BroadheadLoaded
- 563 - StandArrow
- 564 - StandArrowLoaded
- 565 - DullArrow
- 566 - DullArrowLoaded
- 567 - HeavyBolt
- 568 - HeavyBoltLoaded
- 569 - StandBolt
- 570 - StandBoltLoaded
- 571 - DullBolt
- 572 - DullBoltLoaded
- 573 - ThrowingAxeProjectile
- 574 - ThrowingAxe
- 575 - SlingStone
- 576 - SlingStoneLoaded
- 577 - ThrowingKnifeProjectile
- 578 - ThrowingKnife
- 579 - ThrowingJavelinProjectile
- 580 - ThrowingJavelin
- 583 - HandOfBoris
- 584 - HandOfIlyas
- 585 - FireArrowLoaded
- 586 - FireArrow
- 587 - FireworkArrowLoaded
- 588 - FireworkArrow
- 589 - FireworkBoltLoaded
- 590 - FireworkBolt
- 591 - FireworkPot
- 592 - FireworkPotProjectile
- 605 - SwordImage
- 611 - SiegeTorch
- 614 - HeavyTargeShield
- 615 - HeavyHeaterShield
- 616 - HeavyKiteShield
- 617 - SmallKiteShield
- 618 - HeavyIronShield
- 619 - BalancedStaff
- 637 - AnimalTrapData
- 642 - DefaultWeaponData
- 643 - WoodenArrow
- 644 - WoodenArrowLoaded
- 645 - WoodenBolt
- 646 - WoodenBoltLoaded
- 650 - BelieverShovel
- 651 - BelieverHammer
- 652 - BelieverHatchet
- 653 - BelieverPickaxe
- 654 - BelieverSaw
- 655 - BelieverKnife
- 656 - BelieverSickle
- 657 - BelieverCrucibleTongs
- 658 - BelieverFishingPole
- 659 - BelieverCookingPot
- 660 - SiegeStoneExplosion
- 661 - BarrelExplosion
- 662 - NapthaBarrelExplosion
- 663 - CowExplosion
- 664 - PotExplosion
- 665 - FireworkPotExplosion
- 666 - SnowballExplosion
- 686 - WayPointMarker
- 687 - SpawnSphereMarker
- 688 - CameraBookmarkMarker


1026 - MAX datablock id


# Disclaimer
LiF-x / LiFx the team or credited members are not affiliated with BitBox.
