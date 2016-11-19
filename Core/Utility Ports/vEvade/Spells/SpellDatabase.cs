using EloBuddy; 
using LeagueSharp.Common; 
 namespace vEvade.Spells
{
    #region

    using System.Collections.Generic;

    using LeagueSharp;
    using LeagueSharp.Common;

    #endregion

    public static class SpellDatabase
    {
        #region Static Fields

        public static List<SpellData> Spells = new List<SpellData>();

        #endregion

        #region Constructors and Destructors

        static SpellDatabase()
        {
            #region AllChampions

            Spells.Add(
                new SpellData
                    {
                        ChampName = "AllChampions", MenuName = "SnowBall", SpellName = "SummonerSnowball",
                        Slot = SpellSlot.Summoner1, Range = 1600, Delay = 0, Radius = 50, MissileSpeed = 1200,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true, IsSummoner = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "AllChampions", MenuName = "Poro", SpellName = "SummonerPoroThrow",
                        Slot = SpellSlot.Summoner1, Range = 2500, Delay = 0, Radius = 50, MissileSpeed = 1200,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true, IsSummoner = true
                    });

            #endregion AllChampions

            #region Aatrox

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Aatrox", MenuName = "AatroxQ", SpellName = "AatroxQ", DangerValue = 3, Range = 650,
                        Delay = 600, Radius = 265, MissileSpeed = 3050, Type = SpellType.Circle, IsDangerous = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Aatrox", MenuName = "AatroxE", SpellName = "AatroxE",
                        MissileName = "AatroxEConeMissile", DangerValue = 2, Slot = SpellSlot.E, Range = 1075, Radius = 80,
                        MissileSpeed = 1250, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            #endregion Aatrox

            #region Ahri

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Ahri", MenuName = "AhriQ", SpellName = "AhriOrbofDeception",
                        MissileName = "AhriOrbMissile", DangerValue = 2, Range = 1000, Radius = 100, MissileSpeed = 2500,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true,
                        MissileAccel = -3200, MissileMinSpeed = 400, MissileMaxSpeed = 2500
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Ahri", MenuName = "AhriQReturn", SpellName = "AhriOrbReturn",
                        MissileName = "AhriOrbReturn", DangerValue = 3, Range = 20000, Delay = 0, Radius = 100,
                        MissileSpeed = 60, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        MissileToUnit = true, MissileAccel = 1900, MissileMinSpeed = 60, MissileMaxSpeed = 2600
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Ahri", MenuName = "AhriE", SpellName = "AhriSeduce",
                        MissileName = "AhriSeduceMissile", DangerValue = 3, Slot = SpellSlot.E, Range = 1000, Radius = 60,
                        MissileSpeed = 1550,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true, IsDangerous = true
                    });

            #endregion Ahri

            #region Alistar

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Alistar", MenuName = "AlistarQ", SpellName = "Pulverize", DangerValue = 3,
                        Radius = 365, Type = SpellType.Circle
                    });

            #endregion Alistar

            //Todo: next time
            /*
            #region Amumu

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Amumu", MenuName = "AmumuQ", SpellName = "BandageToss",
                        MissileName = "SadMummyBandageToss", DangerValue = 3, Range = 1100, Radius = 80,
                        MissileSpeed = 2000,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true, IsDangerous = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Amumu", MenuName = "AmumuR", SpellName = "CurseoftheSadMummy", DangerValue = 4,
                        Slot = SpellSlot.R, Radius = 550, Type = SpellType.Circle, IsDangerous = true
                    });

            #endregion Amumu

            #region Anivia

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Anivia", MenuName = "AniviaQ", SpellName = "FlashFrostSpell",
                        MissileName = "FlashFrostSpell", DangerValue = 3, Range = 1100, Radius = 110, MissileSpeed = 850,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true, IsDangerous = true,
                        HasEndExplosion = true, RadiusEx = 210
                    });

            #endregion Anivia

            #region Annie

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Annie", MenuName = "AnnieW", SpellName = "Incinerate", DangerValue = 2,
                        Slot = SpellSlot.W, Range = 550, Radius = 50, Type = SpellType.Cone
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Annie", MenuName = "AnnieR", SpellName = "InfernalGuardian", DangerValue = 4,
                        Slot = SpellSlot.R, Range = 600, Radius = 250, Type = SpellType.Circle, IsDangerous = true
                    });

            #endregion Annie

            #region Ashe

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Ashe", MenuName = "AsheW", SpellName = "Volley", MissileName = "VolleyAttack",
                        DangerValue = 2, Slot = SpellSlot.W, Range = 1200, Radius = 20, MissileSpeed = 1500,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true, MultipleNumber = 9,
                        MultipleAngle = 4.97f * (float)Math.PI / 180
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Ashe", MenuName = "AsheR", SpellName = "EnchantedCrystalArrow",
                        MissileName = "EnchantedCrystalArrow", DangerValue = 3, Slot = SpellSlot.R, Range = 25000,
                        Radius = 130, MissileSpeed = 1600,
                        CollisionObjects = new[] { CollisionableObjects.Heroes, CollisionableObjects.YasuoWall },
                        FixedRange = true, IsDangerous = true
                    });

            #endregion Ashe

            #region Aurelion Sol

            Spells.Add(
                new SpellData
                    {
                        ChampName = "AurelionSol", MenuName = "AurelionSolQ", SpellName = "AurelionSolQ",
                        MissileName = "AurelionSolQMissile", DangerValue = 2, Range = 1600, Delay = 0, Radius = 180,
                        MissileSpeed = 630, CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "AurelionSol", MenuName = "AurelionSolR", SpellName = "AurelionSolR",
                        MissileName = "AurelionSolRBeamMissile", DangerValue = 4, Slot = SpellSlot.R, Range = 1500,
                        Delay = 350, Radius = 120, MissileSpeed = 4500,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true
                    });

            #endregion Aurelion Sol

            #region Azir

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Azir", MenuName = "AzirQ", SpellName = "AzirQWrapper",
                        MissileName = "AzirSoldierMissile", DangerValue = 2, Range = 25000, Delay = 0, Radius = 70,
                        MissileSpeed = 1600, MissileOnly = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Azir", MenuName = "AzirR", SpellName = "AzirR", DangerValue = 3, Slot = SpellSlot.R,
                        Range = 760, Radius = 60, MissileSpeed = 1400,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true
                    });

            #endregion Azir

            #region Bard

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Bard", MenuName = "BardQ", SpellName = "BardQ", MissileName = "BardQMissile",
                        DangerValue = 3, Range = 950, Radius = 60, MissileSpeed = 1500,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Bard", MenuName = "BardR", SpellName = "BardR",
                        MissileName = "BardRMissileFixedTravelTime",
                        ExtraMissileNames =
                            new[]
                                {
                                    "BardRMissileRange1", "BardRMissileRange2", "BardRMissileRange3", "BardRMissileRange4",
                                    "BardRMissileRange5"
                                },
                        DangerValue = 2, Slot = SpellSlot.R, Range = 3400, Delay = 500,
                        Radius = 350, MissileSpeed = 2100, Type = SpellType.Circle
                    });

            #endregion Bard

            #region Blitzcrank

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Blitzcrank", MenuName = "BlitzcrankQ", SpellName = "RocketGrab",
                        MissileName = "RocketGrabMissile", DangerValue = 3, Range = 1050, Radius = 70, MissileSpeed = 1800,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Blitzcrank", MenuName = "BlitzcrankR", SpellName = "StaticField", DangerValue = 2,
                        Slot = SpellSlot.R, Radius = 600, Type = SpellType.Circle
                    });

            #endregion Blitzcrank

            #region Brand

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Brand", MenuName = "BrandQ", SpellName = "BrandQ", MissileName = "BrandQMissile",
                        DangerValue = 3, Range = 1100, Radius = 60, MissileSpeed = 1600,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Brand", MenuName = "BrandW", SpellName = "BrandW", DangerValue = 3,
                        Slot = SpellSlot.W, Range = 900, Delay = 850, Radius = 240, Type = SpellType.Circle
                    });

            #endregion Brand

            #region Braum

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Braum", MenuName = "BraumQ", SpellName = "BraumQ", MissileName = "BraumQMissile",
                        DangerValue = 3, Range = 1050, Radius = 60, MissileSpeed = 1700,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Braum", MenuName = "BraumR", SpellName = "BraumRWrapper",
                        MissileName = "BraumRMissile", DangerValue = 4, Slot = SpellSlot.R, Range = 1200, Delay = 500,
                        Radius = 115, MissileSpeed = 1400, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        FixedRange = true, HasStartExplosion = true, RadiusEx = 240
                    });

            #endregion Braum

            #region Caitlyn

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Caitlyn", MenuName = "CaitlynQ", SpellName = "CaitlynPiltoverPeacemaker",
                        MissileName = "CaitlynPiltoverPeacemaker", Range = 1300, Delay = 625, Radius = 60,
                        MissileSpeed = 2200, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Caitlyn", MenuName = "CaitlynQBehind", SpellName = "CaitlynQBehind",
                        MissileName = "CaitlynPiltoverPeacemaker2", DangerValue = 2, Range = 1300, Delay = 0, Radius = 90,
                        MissileSpeed = 2200, CollisionObjects = new[] { CollisionableObjects.YasuoWall }
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Caitlyn", MenuName = "CaitlynE", SpellName = "CaitlynEntrapment",
                        MissileName = "CaitlynEntrapmentMissile", DangerValue = 3, Slot = SpellSlot.E, Range = 800,
                        Delay = 150, Radius = 70, MissileSpeed = 1600,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            #endregion Caitlyn

            #region Cassiopeia

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Cassiopeia", MenuName = "CassiopeiaQ", SpellName = "CassiopeiaQ", Range = 850,
                        Delay = 750, Radius = 160, Type = SpellType.Circle
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Cassiopeia", MenuName = "CassiopeiaR", SpellName = "CassiopeiaR", DangerValue = 4,
                        Slot = SpellSlot.R, Range = 770, Delay = 500, Radius = 80, Type = SpellType.Cone
                    });

            #endregion Cassiopeia

            #region Chogath

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Chogath", MenuName = "ChogathQ", SpellName = "Rupture", DangerValue = 3, Range = 950,
                        Delay = 1200, Radius = 250, Type = SpellType.Circle
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Chogath", MenuName = "ChogathW", SpellName = "FeralScream", DangerValue = 2,
                        Slot = SpellSlot.W, Range = 620, Delay = 500, Radius = 55, Type = SpellType.Cone
                    });

            #endregion Chogath

            #region Corki

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Corki", MenuName = "CorkiQ", SpellName = "PhosphorusBomb",
                        MissileName = "PhosphorusBombMissile", ExtraMissileNames = new[] { "PhosphorusBombMissileMin" },
                        DangerValue = 2, Range = 825, Radius = 250, MissileSpeed = 1000, Type = SpellType.Circle,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Corki", MenuName = "CorkiR", SpellName = "MissileBarrageMissile",
                        MissileName = "MissileBarrageMissile", Slot = SpellSlot.R, Range = 1300, Delay = 175, Radius = 40,
                        MissileSpeed = 2000,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Corki", MenuName = "CorkiREmpower", SpellName = "MissileBarrageMissile2",
                        MissileName = "MissileBarrageMissile2", DangerValue = 3, Slot = SpellSlot.R, Range = 1500,
                        Delay = 175, Radius = 40, MissileSpeed = 2000,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            #endregion Corki

            #region Darius

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Darius", MenuName = "DariusQ", SpellName = "DariusCleave", DangerValue = 2,
                        Delay = 700, Radius = 425, Type = SpellType.Ring, MissileToUnit = true, RadiusEx = 205,
                        ExtraDuration = 350
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Darius", MenuName = "DariusE", SpellName = "DariusAxeGrabCone", DangerValue = 3,
                        Slot = SpellSlot.E, Range = 490, Delay = 260, Radius = 50, Type = SpellType.Cone
                    });

            #endregion Darius

            #region Diana

            Spells.Add(
                //Todo: Arc
                new SpellData
                    {
                        ChampName = "Diana", MenuName = "DianaQ", SpellName = "DianaArc", DangerValue = 3, Range = 850,
                        Delay = 250, Radius = 50, MissileSpeed = 1400, Type = SpellType.Arc, FixedRange = true,
                        HasEndExplosion = true, RadiusEx = 195, ExtraDuration = 250
                    });

            #endregion Diana

            #region DrMundo

            Spells.Add(
                new SpellData
                    {
                        ChampName = "DrMundo", MenuName = "DrMundoQ", SpellName = "InfectedCleaverMissile",
                        MissileName = "InfectedCleaverMissile", DangerValue = 2, Range = 1050, Radius = 60,
                        MissileSpeed = 2000,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            #endregion DrMundo

            #region Draven

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Draven", MenuName = "DravenE", SpellName = "DravenDoubleShot",
                        MissileName = "DravenDoubleShotMissile", DangerValue = 2, Slot = SpellSlot.E, Range = 1100,
                        Radius = 130, MissileSpeed = 1400, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Draven", MenuName = "DravenR", SpellName = "DravenRCast", MissileName = "DravenR",
                        DangerValue = 2, Slot = SpellSlot.R, Range = 25000, Delay = 500, Radius = 160, MissileSpeed = 2000,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true
                    });

            #endregion Draven

            #region Ekko

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Ekko", MenuName = "EkkoQ", SpellName = "EkkoQ", MissileName = "EkkoQMis",
                        DangerValue = 3, Range = 950, Radius = 60, MissileSpeed = 1650,
                        CollisionObjects = new[] { CollisionableObjects.Heroes, CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Ekko", MenuName = "EkkoQReturn", SpellName = "EkkoQReturn",
                        MissileName = "EkkoQReturn", DangerValue = 3, Range = 25000, Delay = 0, Radius = 100,
                        MissileSpeed = 2300, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        MissileToUnit = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Ekko", MenuName = "EkkoW", SpellName = "EkkoW", MissileName = "EkkoWMis",
                        DangerValue = 2, Slot = SpellSlot.W, Range = 25000, Delay = 2200, Radius = 375,
                        MissileSpeed = 1500, Type = SpellType.Circle, DelayEx = 700
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Ekko", MenuName = "EkkoR", SpellName = "EkkoR", DangerValue = 3, Slot = SpellSlot.R,
                        Range = 25000, Radius = 375, MissileSpeed = 5000, Type = SpellType.Circle
                    });

            #endregion Ekko

            #region Elise

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Elise", MenuName = "EliseHumanE", SpellName = "EliseHumanE",
                        MissileName = "EliseHumanE", DangerValue = 3, Slot = SpellSlot.E, Range = 1100, Radius = 55,
                        MissileSpeed = 1600,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            #endregion Elise

            #region Evelynn

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Evelynn", MenuName = "EvelynnR", SpellName = "EvelynnR", DangerValue = 3,
                        Slot = SpellSlot.R, Range = 650, Delay = 200, Radius = 350, Type = SpellType.Circle
                    });

            #endregion Evelynn

            #region Ezreal

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Ezreal", MenuName = "EzrealQ", SpellName = "EzrealMysticShot",
                        MissileName = "EzrealMysticShotMissile", DangerValue = 2, Range = 1200, Radius = 60,
                        MissileSpeed = 2000,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Ezreal", MenuName = "EzrealW", SpellName = "EzrealEssenceFlux",
                        MissileName = "EzrealEssenceFluxMissile", Slot = SpellSlot.W, Range = 1050, Radius = 80,
                        MissileSpeed = 1600, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Ezreal", MenuName = "EzrealR", SpellName = "EzrealTrueshotBarrage",
                        MissileName = "EzrealTrueshotBarrage", DangerValue = 3, Slot = SpellSlot.R, Range = 25000,
                        Delay = 1000, Radius = 160, MissileSpeed = 2000,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true
                    });

            #endregion Ezreal

            #region Fiora

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Fiora", MenuName = "FioraW", SpellName = "FioraW", MissileName = "FioraWMissile",
                        DangerValue = 2, Slot = SpellSlot.W, Range = 750, Delay = 500, Radius = 70, MissileSpeed = 3200,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true
                    });

            #endregion Fiora

            #region Fizz

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Fizz", MenuName = "FizzQ", SpellName = "FizzPiercingStrike", DangerValue = 2,
                        Range = 550, Delay = 0, Radius = 120, MissileSpeed = 1400, FixedRange = true
                    });

            Spells.Add(
                //Todo: End Exp
                new SpellData
                    {
                        ChampName = "Fizz", MenuName = "FizzR", SpellName = "FizzMarinerDoom",
                        MissileName = "FizzMarinerDoomMissile", DangerValue = 3, Slot = SpellSlot.R, Range = 1250,
                        Radius = 120, MissileSpeed = 1350,
                        CollisionObjects = new[] { CollisionableObjects.Heroes, CollisionableObjects.YasuoWall },
                        RadiusEx = 200
                    });

            #endregion Fizz

            #region Galio

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Galio", MenuName = "GalioQ", SpellName = "GalioResoluteSmite",
                        MissileName = "GalioResoluteSmite", DangerValue = 2, Range = 1040, Radius = 235,
                        MissileSpeed = 1200, Type = SpellType.Circle,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Galio", MenuName = "GalioE", SpellName = "GalioRighteousGust",
                        MissileName = "GalioRighteousGust", DangerValue = 2, Slot = SpellSlot.E, Range = 1280,
                        Radius = 120, MissileSpeed = 1300, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Galio", MenuName = "GalioR", SpellName = "GalioIdolOfDurand", DangerValue = 4,
                        Slot = SpellSlot.R, Radius = 600, Type = SpellType.Circle
                    });

            #endregion Galio

            #region Gnar

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Gnar", MenuName = "GnarQ", SpellName = "GnarQMissile", MissileName = "GnarQMissile",
                        DangerValue = 2, Range = 1125, Radius = 55, MissileSpeed = 2500,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true,
                        MissileAccel = -3000, MissileMinSpeed = 1400, MissileMaxSpeed = 2500
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Gnar", MenuName = "GnarQReturn", SpellName = "GnarQMissileReturn",
                        MissileName = "GnarQMissileReturn", DangerValue = 2, Range = 25000, Delay = 0, Radius = 75,
                        MissileSpeed = 60, CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true,
                        MissileAccel = 800, MissileMinSpeed = 60, MissileMaxSpeed = 2600
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Gnar", MenuName = "GnarQBig", SpellName = "GnarBigQMissile",
                        MissileName = "GnarBigQMissile", DangerValue = 2, Range = 1150, Delay = 500, Radius = 90,
                        MissileSpeed = 2100,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Gnar", MenuName = "GnarWBig", SpellName = "GnarBigW", DangerValue = 3,
                        Slot = SpellSlot.W, Range = 600, Delay = 600, Radius = 80, FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Gnar", MenuName = "GnarE", SpellName = "GnarE", DangerValue = 2, Slot = SpellSlot.E,
                        Range = 475, Delay = 0, Radius = 150, MissileSpeed = 900, Type = SpellType.Circle
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Gnar", MenuName = "GnarEBig", SpellName = "GnarBigE", DangerValue = 2,
                        Slot = SpellSlot.E, Range = 475, Delay = 0, Radius = 350, MissileSpeed = 800,
                        Type = SpellType.Circle
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Gnar", MenuName = "GnarR", SpellName = "GnarR", DangerValue = 4, Slot = SpellSlot.R,
                        Radius = 500, Type = SpellType.Circle
                    });

            #endregion Gnar

            #region Gragas

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Gragas", MenuName = "GragasQ", SpellName = "GragasQ", MissileName = "GragasQMissile",
                        ToggleName = "Gragas_.+_Q_(Enemy|Ally)", DangerValue = 2, Range = 850, Radius = 250,
                        MissileSpeed = 1000, Type = SpellType.Circle, ExtraDuration = 4000
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Gragas", MenuName = "GragasE", SpellName = "GragasE", DangerValue = 3,
                        Slot = SpellSlot.E, Range = 700, Delay = 0, Radius = 200, MissileSpeed = 900,
                        CollisionObjects = new[] { CollisionableObjects.Heroes, CollisionableObjects.Minions },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Gragas", MenuName = "GragasR", SpellName = "GragasR", MissileName = "GragasRBoom",
                        DangerValue = 4, Slot = SpellSlot.R, Range = 1000, Radius = 350, MissileSpeed = 1800,
                        Type = SpellType.Circle, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        DelayEx = 150
                    });

            #endregion Gragas

            #region Graves

            Spells.Add(
                //Todo: Split
                new SpellData
                    {
                        ChampName = "Graves", MenuName = "GravesQ", SpellName = "GravesQLineSpell",
                        MissileName = "GravesQLineMis", DangerValue = 3, Range = 800, Radius = 40, MissileSpeed = 3000,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Graves", MenuName = "GravesQReturn", SpellName = "GravesQReturn",
                        MissileName = "GravesQReturn", DangerValue = 2, Range = 800, Delay = 0, Radius = 100,
                        MissileSpeed = 1600, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Graves", MenuName = "GravesW", SpellName = "GravesSmokeGrenade",
                        MissileName = "GravesSmokeGrenadeBoom", ToggleName = "Graves_SmokeGrenade_.+_Team_",
                        Slot = SpellSlot.W, Range = 950, Radius = 250, MissileSpeed = 1500, Type = SpellType.Circle,
                        ExtraDuration = 4000
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Graves", MenuName = "GravesR", SpellName = "GravesChargeShot",
                        MissileName = "GravesChargeShotShot", DangerValue = 4, Slot = SpellSlot.R, Range = 1000,
                        Radius = 100, MissileSpeed = 2100, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Graves", MenuName = "GravesRExplosion", SpellName = "GravesRExplosion",
                        MissileName = "GravesChargeShotFxMissile",
                        ExtraMissileNames = new[] { "GravesChargeShotFxMissile2" }, DangerValue = 4, Slot = SpellSlot.R,
                        Range = 650, Delay = 0, Radius = 80, MissileSpeed = 2000, FixedRange = true
                    });

            #endregion Graves

            #region Hecarim

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Hecarim", MenuName = "HecarimR", SpellName = "HecarimUlt",
                        MissileName = "HecarimUltMissile", DangerValue = 4, Slot = SpellSlot.R, Range = 1550, Delay = 10,
                        Radius = 240, MissileSpeed = 1100, FixedRange = true
                    });

            #endregion Hecarim

            #region Heimerdinger

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Heimerdinger", MenuName = "HeimerdingerQTurretBlast",
                        SpellName = "HeimerdingerQTurretBlast", MissileName = "HeimerdingerTurretEnergyBlast",
                        DangerValue = 2, Range = 1000, Delay = 0, Radius = 50, MissileSpeed = 1650, FixedRange = true,
                        MissileAccel = -1000, MissileMinSpeed = 1200, MissileMaxSpeed = 1650, MissileOnly = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Heimerdinger", MenuName = "HeimerdingerQTurretBigBlast",
                        SpellName = "HeimerdingerQTurretBigBlast", MissileName = "HeimerdingerTurretBigEnergyBlast",
                        DangerValue = 3, Range = 1000, Delay = 0, Radius = 75, MissileSpeed = 1650,
                        CollisionObjects = new[] { CollisionableObjects.Minions }, FixedRange = true, MissileAccel = -1000,
                        MissileMinSpeed = 1200, MissileMaxSpeed = 1650, MissileOnly = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Heimerdinger", MenuName = "HeimerdingerW", SpellName = "HeimerdingerW",
                        MissileName = "HeimerdingerWAttack2", ExtraMissileNames = new[] { "HeimerdingerWAttack2Ult" },
                        DangerValue = 2, Slot = SpellSlot.W, Range = 1350, Radius = 40, MissileSpeed = 750,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true, MissileAccel = 4000,
                        MissileMinSpeed = 750, MissileMaxSpeed = 3000, MissileOnly = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Heimerdinger", MenuName = "HeimerdingerE", SpellName = "HeimerdingerE",
                        MissileName = "HeimerdingerESpell", DangerValue = 2, Slot = SpellSlot.E, Range = 925, Radius = 180,
                        MissileSpeed = 1200, Type = SpellType.Circle,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }
                    });

            Spells.Add(
                //Todo: Tweak
                new SpellData
                    {
                        ChampName = "Heimerdinger", MenuName = "HeimerdingerEUlt", SpellName = "HeimerdingerEUlt",
                        MissileName = "HeimerdingerESpell_ult",
                        ExtraMissileNames = new[] { "HeimerdingerESpell_ult2", "HeimerdingerESpell_ult3" },
                        DangerValue = 2, Slot = SpellSlot.E, Range = 925, Radius = 300, MissileSpeed = 1200,
                        Type = SpellType.Circle, CollisionObjects = new[] { CollisionableObjects.YasuoWall }
                    });

            #endregion Heimerdinger

            #region Illaoi

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Illaoi", MenuName = "IllaoiQ", SpellName = "IllaoiQ", DangerValue = 3, Range = 850,
                        Delay = 750, Radius = 100, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Illaoi", MenuName = "Illaoi", SpellName = "IllaoiE", MissileName = "IllaoiEMis",
                        DangerValue = 3, Slot = SpellSlot.E, Range = 950, Radius = 50, MissileSpeed = 1900,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Illaoi", MenuName = "Illaoi", SpellName = "IllaoiR", DangerValue = 3,
                        Slot = SpellSlot.R, Delay = 500, Radius = 450, Type = SpellType.Circle
                    });

            #endregion Illaoi

            #region Irelia

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Irelia", MenuName = "Irelia", SpellName = "IreliaTranscendentBlades",
                        MissileName = "IreliaTranscendentBladesSpell", DangerValue = 2, Slot = SpellSlot.R, Range = 1200,
                        Delay = 0, Radius = 120, MissileSpeed = 1600,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true,
                        DontCheckForDuplicates = true
                    });

            #endregion Irelia

            #region Ivern

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Ivern", MenuName = "IvernQ", SpellName = "IvernQ", MissileName = "IvernQ",
                        DangerValue = 3, Range = 1100, Radius = 65, MissileSpeed = 1300,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            #endregion Ivern

            #region Janna

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Janna", MenuName = "JannaQ", SpellName = "HowlingGale",
                        MissileName = "HowlingGaleSpell", DangerValue = 2, Range = 1700, Delay = 0, Radius = 120,
                        MissileSpeed = 900, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        MissileOnly = true
                    });

            #endregion Janna

            #region JarvanIV

            Spells.Add(
                new SpellData
                    {
                        ChampName = "JarvanIV", MenuName = "JarvanIVQ", SpellName = "JarvanIVDragonStrike",
                        DangerValue = 2, Range = 770, Delay = 400, Radius = 70, FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "JarvanIV", MenuName = "JarvanIVQE", SpellName = "JarvanIVQE", DangerValue = 3,
                        Range = 900, Delay = 450, Radius = 120, MissileSpeed = 2550
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "JarvanIV", MenuName = "JarvanIVE", SpellName = "JarvanIVDemacianStandard",
                        Slot = SpellSlot.E, Range = 850, Delay = 500, Radius = 175, Type = SpellType.Circle
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "JarvanIV", MenuName = "JarvanIVR", SpellName = "JarvanIVCataclysm", DangerValue = 3,
                        Slot = SpellSlot.R, Range = 825, Delay = 0, Radius = 350, MissileSpeed = 1900,
                        Type = SpellType.Circle
                    });

            #endregion JarvanIV

            #region Jayce

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Jayce", MenuName = "JayceQ", SpellName = "JayceShockBlast",
                        MissileName = "JayceShockBlastMis", DangerValue = 2, Delay = 230, Range = 1070, Radius = 70,
                        MissileSpeed = 1450,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true, HasEndExplosion = true,
                        RadiusEx = 210
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Jayce", MenuName = "JayceQEmpower", SpellName = "JayceShockBlastAccel",
                        MissileName = "JayceShockBlastWallMis", DangerValue = 3, Range = 1600, Delay = 0, Radius = 70,
                        MissileSpeed = 2350,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        HasEndExplosion = true, RadiusEx = 210
                    });

            #endregion Jayce

            #region Jinx

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Jinx", MenuName = "JinxW", SpellName = "JinxWMissile", MissileName = "JinxWMissile",
                        DangerValue = 3, Slot = SpellSlot.W, Range = 1500, Delay = 600, Radius = 60, MissileSpeed = 3300,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Jinx", MenuName = "JinxR", SpellName = "JinxR", MissileName = "JinxR",
                        DangerValue = 3, Slot = SpellSlot.R, Range = 25000, Delay = 600, Radius = 140, MissileSpeed = 1700,
                        CollisionObjects = new[] { CollisionableObjects.Heroes, CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            #endregion Jinx

            #region Jhin   

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Jhin", MenuName = "JhinW", SpellName = "JhinW", DangerValue = 3, Slot = SpellSlot.W,
                        Range = 2550, Delay = 750, Radius = 40,
                        CollisionObjects = new[] { CollisionableObjects.Heroes, CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Jhin", MenuName = "JhinR", SpellName = "JhinRShot", MissileName = "JhinRShotMis",
                        ExtraMissileNames = new[] { "JhinRShotMis4" }, DangerValue = 3, Slot = SpellSlot.R, Range = 3500,
                        Delay = 200, Radius = 80, MissileSpeed = 5000,
                        CollisionObjects = new[] { CollisionableObjects.Heroes, CollisionableObjects.YasuoWall },
                        FixedRange = true, DontCheckForDuplicates = true
                    });

            #endregion

            #region Kalista

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Kalista", MenuName = "KalistaQ", SpellName = "KalistaMysticShot",
                        MissileName = "KalistaMysticShotMisTrue", DangerValue = 2, Range = 1200, Radius = 40,
                        MissileSpeed = 2400,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            #endregion Kalista

            #region Karma

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Karma", MenuName = "KarmaQ", SpellName = "KarmaQ", MissileName = "KarmaQMissile",
                        DangerValue = 2, Range = 1050, Radius = 60, MissileSpeed = 1700,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Karma", MenuName = "KarmaQMantra", SpellName = "KarmaQMantra",
                        MissileName = "KarmaQMissileMantra", DangerValue = 3, Range = 950, Delay = 0, Radius = 80,
                        MissileSpeed = 1700,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true, MissileOnly = true,
                        HasEndExplosion = true, RadiusEx = 300
                    });

            #endregion Karma

            #region Karthus

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Karthus", MenuName = "KarthusQ", SpellName = "KarthusLayWasteA1",
                        ExtraSpellNames =
                            new[]
                                {
                                    "KarthusLayWasteA2", "KarthusLayWasteA3", "KarthusLayWasteDeadA1",
                                    "KarthusLayWasteDeadA2", "KarthusLayWasteDeadA3"
                                },
                        DangerValue = 2, Range = 875,
                        Delay = 875, Radius = 160, Type = SpellType.Circle
                    });

            #endregion Karthus

            #region Kassadin

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Kassadin", MenuName = "KassadinE", SpellName = "ForcePulse", DangerValue = 2,
                        Slot = SpellSlot.E, Range = 600, Radius = 73, Type = SpellType.Cone
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Kassadin", MenuName = "KassadinR", SpellName = "RiftWalk", Slot = SpellSlot.R,
                        Range = 500, Radius = 270, Type = SpellType.Circle
                    });

            #endregion Kassadin

            #region Kennen

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Kennen", MenuName = "KennenQ", SpellName = "KennenShurikenHurlMissile1",
                        MissileName = "KennenShurikenHurlMissile1", DangerValue = 2, Range = 1050, Delay = 175,
                        Radius = 50, MissileSpeed = 1700,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            #endregion Kennen

            #region Khazix

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Khazix", MenuName = "KhazixW", SpellName = "KhazixW",
                        ExtraSpellNames = new[] { "KhazixWLong" }, MissileName = "KhazixWMissile", Slot = SpellSlot.W,
                        Range = 1025, Radius = 70, MissileSpeed = 1700,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true, MultipleNumber = 3,
                        MultipleAngle = 22 * (float)Math.PI / 180
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Khazix", MenuName = "KhazixE", SpellName = "KhazixE", Slot = SpellSlot.E, Range = 700,
                        Delay = 0, Radius = 300, MissileSpeed = 1250, Type = SpellType.Circle
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Khazix", MenuName = "KhazixEEvol", SpellName = "KhazixELong", Slot = SpellSlot.E,
                        Range = 900, Delay = 0, Radius = 300, MissileSpeed = 1200, Type = SpellType.Circle
                    });

            #endregion Khazix

            #region Kled

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Kled", MenuName = "KledQ", SpellName = "KledQ", MissileName = "KledQMissile",
                        DangerValue = 3, Range = 800, Delay = 250, Radius = 45, MissileSpeed = 1600,
                        CollisionObjects = new[] { CollisionableObjects.Heroes, CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Kled", MenuName = "Pocket Pistol", SpellName = "KledRiderQ",
                        MissileName = "KledRiderQMissile", DangerValue = 2, Range = 700, Delay = 250, Radius = 40,
                        MissileSpeed = 3000, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        FixedRange = true, MultipleNumber = 5, MultipleAngle = 5 * (float)Math.PI / 180
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Kled", MenuName = "Jousting", SpellName = "KledE", DangerValue = 2,
                        Slot = SpellSlot.E, Range = 750, Delay = 0, Radius = 125, MissileSpeed = 945
                    });

            #endregion Kled

            #region KogMaw

            Spells.Add(
                new SpellData
                    {
                        ChampName = "KogMaw", MenuName = "KogMawQ", SpellName = "KogMawQ", MissileName = "KogMawQ",
                        DangerValue = 2, Range = 1200, Radius = 70, MissileSpeed = 1650,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "KogMaw", MenuName = "KogMawE", SpellName = "KogMawVoidOozeMissile",
                        MissileName = "KogMawVoidOozeMissile", DangerValue = 2, Slot = SpellSlot.E, Range = 1360,
                        Radius = 120, MissileSpeed = 1400, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "KogMaw", MenuName = "KogMawR", SpellName = "KogMawLivingArtillery", DangerValue = 2,
                        Slot = SpellSlot.R, Range = 1200, Delay = 1150, Radius = 240, Type = SpellType.Circle
                    });

            #endregion KogMaw

            #region Leblanc

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Leblanc", MenuName = "LeblancW", SpellName = "LeblancSlide", DangerValue = 2,
                        Slot = SpellSlot.W, Range = 600, Delay = 30, Radius = 220, MissileSpeed = 1450,
                        Type = SpellType.Circle
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Leblanc", MenuName = "LeblancWUlt", SpellName = "LeblancSlideM", DangerValue = 2,
                        Slot = SpellSlot.R, Range = 600, Delay = 30, Radius = 220, MissileSpeed = 1450,
                        Type = SpellType.Circle
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Leblanc", MenuName = "LeblancE", SpellName = "LeblancSoulShackle",
                        MissileName = "LeblancSoulShackle", DangerValue = 3, Slot = SpellSlot.E, Range = 950, Radius = 55,
                        MissileSpeed = 1750,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Leblanc", MenuName = "LeblancEUlt", SpellName = "LeblancSoulShackleM",
                        MissileName = "LeblancSoulShackleM", DangerValue = 3, Slot = SpellSlot.R, Range = 950, Radius = 55,
                        MissileSpeed = 1750,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            #endregion Leblanc

            #region LeeSin

            Spells.Add(
                new SpellData
                    {
                        ChampName = "LeeSin", MenuName = "LeeSinQ", SpellName = "BlindMonkQOne",
                        MissileName = "BlindMonkQOne", DangerValue = 3, Range = 1100, Radius = 60, MissileSpeed = 1800,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            #endregion LeeSin

            #region Leona

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Leona", MenuName = "LeonaE", SpellName = "LeonaZenithBlade",
                        MissileName = "LeonaZenithBladeMissile", DangerValue = 3, Slot = SpellSlot.E, Range = 900,
                        Radius = 70, MissileSpeed = 2000, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Leona", MenuName = "LeonaR", SpellName = "LeonaSolarFlare", DangerValue = 4,
                        Slot = SpellSlot.R, Range = 1200, Delay = 900, Radius = 300, Type = SpellType.Circle
                    });

            #endregion Leona

            #region Lissandra

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Lissandra", MenuName = "LissandraQ", SpellName = "LissandraQMissile",
                        MissileName = "LissandraQMissile", DangerValue = 2, Range = 750, Radius = 75, MissileSpeed = 2200,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Lissandra", MenuName = "LissandraQExplosion", SpellName = "LissandraQShards",
                        MissileName = "LissandraQShards", DangerValue = 2, Range = 1650, Delay = 0, Radius = 90,
                        MissileSpeed = 2200, CollisionObjects = new[] { CollisionableObjects.YasuoWall }
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Lissandra", MenuName = "LissandraW", SpellName = "LissandraW", DangerValue = 3,
                        Slot = SpellSlot.W, Delay = 0, Radius = 450, Type = SpellType.Circle
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Lissandra", MenuName = "LissandraE", SpellName = "LissandraEMissile",
                        MissileName = "LissandraEMissile", Slot = SpellSlot.E, Range = 1025, Radius = 125,
                        MissileSpeed = 850, CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true
                    });

            #endregion Lissandra

            #region Lucian

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Lucian", MenuName = "LucianQ", SpellName = "LucianQ", DangerValue = 3, Range = 900,
                        Delay = 350, Radius = 65, FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Lucian", MenuName = "LucianW", SpellName = "LucianW", MissileName = "LucianWMissile",
                        Slot = SpellSlot.W, Range = 930, Delay = 300, Radius = 55, MissileSpeed = 1600,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Lucian", MenuName = "LucianR", SpellName = "LucianRMis",
                        MissileName = "LucianRMissileOffhand", ExtraMissileNames = new[] { "LucianRMissile" },
                        DangerValue = 2, Slot = SpellSlot.R, Range = 1200, Delay = 0, Radius = 110, MissileSpeed = 2800,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true, MissileOnly = true
                    });

            #endregion Lucian

            #region Lulu

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Lulu", MenuName = "LuluQ", SpellName = "LuluQ", MissileName = "LuluQMissile",
                        ExtraMissileNames = new[] { "LuluQMissileTwo" }, DangerValue = 2, Range = 950, Delay = 250,
                        Radius = 60, MissileSpeed = 1450, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            #endregion Lulu

            #region Lux

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Lux", MenuName = "LuxQ", SpellName = "LuxLightBinding",
                        MissileName = "LuxLightBindingMis", DangerValue = 3, Range = 1300, Radius = 70,
                        MissileSpeed = 1200, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Lux", MenuName = "LuxE", SpellName = "LuxLightStrikeKugel",
                        MissileName = "LuxLightStrikeKugel", ToggleName = "Lux_.+_E_tar_aoe_", DangerValue = 2,
                        Slot = SpellSlot.E, Range = 1100, Radius = 330, MissileSpeed = 1300, Type = SpellType.Circle,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, ExtraDuration = 5000
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Lux", MenuName = "LuxR", SpellName = "LuxMaliceCannon", DangerValue = 4,
                        Slot = SpellSlot.R, Range = 3300, Delay = 1000, Radius = 150, FixedRange = true
                    });

            #endregion Lux

            #region Maokai

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Maokai", MenuName = "MaokaiQ", SpellName = "MaokaiTrunkLine",
                        MissileName = "MaokaiTrunkLineMissileQ", DangerValue = 3, Range = 650, Delay = 420, Radius = 110,
                        MissileSpeed = 1800, FixedRange = true, HasStartExplosion = true, RadiusEx = 275
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Maokai", MenuName = "MaokaiE", SpellName = "MaokaiSapling2",
                        MissileName = "MaokaiSapling2Boom", Slot = SpellSlot.E, Range = 1100, Delay = 375, Radius = 225,
                        MissileSpeed = 1500, Type = SpellType.Circle, DelayEx = 550
                    });

            #endregion Maokai

            #region Mordekaiser

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Mordekaiser", MenuName = "MordekaiserE", SpellName = "MordekaiserSyphonOfDestruction",
                        DangerValue = 3, Slot = SpellSlot.E, Range = 630, Radius = 50, Type = SpellType.Cone
                    });

            #endregion Mordekaiser

            #region Malphite

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Malphite", MenuName = "MalphiteR", SpellName = "UFSlash", DangerValue = 4,
                        Slot = SpellSlot.R, Range = 1000, Delay = 0, Radius = 270, MissileSpeed = 1500,
                        Type = SpellType.Circle
                    });

            #endregion Malphite

            #region Malzahar

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Malzahar", MenuName = "MalzaharQ", SpellName = "MalzaharQ",
                        MissileName = "MalzaharQMissile", DangerValue = 2, Range = 750, Delay = 510, Radius = 85,
                        MissileSpeed = 1600, FixedRange = true
                    });

            #endregion Malzahar

            #region MonkeyKing

            Spells.Add(
                new SpellData
                    {
                        ChampName = "MonkeyKing", MenuName = "MonkeyKingR", SpellName = "MonkeyKingSpinToWin",
                        DangerValue = 4, Slot = SpellSlot.R, Delay = 0, Radius = 320, Type = SpellType.Circle
                    });

            #endregion MonkeyKing

            #region Morgana

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Morgana", MenuName = "MorganaQ", SpellName = "DarkBindingMissile",
                        MissileName = "DarkBindingMissile", DangerValue = 3, Range = 1300, Radius = 70,
                        MissileSpeed = 1200,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            #endregion Morgana

            #region Nami

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Nami", MenuName = "NamiQ", SpellName = "NamiQ", MissileName = "NamiQMissile",
                        DangerValue = 3, Range = 850, Delay = 250, Radius = 200, MissileSpeed = 2500,
                        Type = SpellType.Circle, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        DelayEx = 650
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Nami", MenuName = "NamiR", SpellName = "NamiR", MissileName = "NamiRMissile",
                        DangerValue = 2, Slot = SpellSlot.R, Range = 2750, Delay = 500, Radius = 250, MissileSpeed = 850,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true
                    });

            #endregion Nami

            #region Nautilus

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Nautilus", MenuName = "NautilusQ", SpellName = "NautilusAnchorDrag",
                        MissileName = "NautilusAnchorDragMissile", DangerValue = 3, Range = 1100, Radius = 90,
                        MissileSpeed = 2000,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            #endregion Nautilus

            #region Nidalee

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Nidalee", MenuName = "NidaleeQ", SpellName = "JavelinToss",
                        MissileName = "JavelinToss", DangerValue = 3, Range = 1500, Delay = 250, Radius = 40,
                        MissileSpeed = 1300,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            #endregion Nidalee

            #region Nocturne

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Nocturne", MenuName = "NocturneQ", SpellName = "NocturneDuskbringer",
                        MissileName = "NocturneDuskbringer", DangerValue = 2, Range = 1200, Radius = 60,
                        MissileSpeed = 1400, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            #endregion Nocturne

            #region Olaf

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Olaf", MenuName = "OlafQ", SpellName = "OlafAxeThrowCast",
                        MissileName = "OlafAxeThrow", DangerValue = 2, Range = 1000, Radius = 90, MissileSpeed = 1600,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }
                    });

            #endregion Olaf

            #region Orianna

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Orianna", MenuName = "OriannaQ", SpellName = "OrianaIzunaCommand",
                        MissileName = "OrianaIzuna", DangerValue = 2, Range = 2000, Delay = 0, Radius = 80,
                        MissileSpeed = 1200, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        UseEndPosition = true, RadiusEx = 145
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Orianna", MenuName = "OriannaW", SpellName = "OrianaDissonanceCommand",
                        DangerValue = 2, Slot = SpellSlot.W, Delay = 0, Radius = 255, Type = SpellType.Circle
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Orianna", MenuName = "OriannaR", SpellName = "OrianaDetonateCommand", DangerValue = 4,
                        Slot = SpellSlot.R, Delay = 500, Radius = 410, Type = SpellType.Circle
                    });

            #endregion Orianna

            #region Pantheon

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Pantheon", MenuName = "PantheonE", SpellName = "PantheonE", DangerValue = 2,
                        Slot = SpellSlot.E, Range = 630, Delay = 400, Radius = 70, Type = SpellType.Cone,
                        ExtraDuration = 750
                    });

            #endregion Pantheon

            #region Poppy

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Poppy", MenuName = "PoppyQ", SpellName = "PoppyQ", DangerValue = 2, Range = 430,
                        Delay = 500, Radius = 100, FixedRange = true, ExtraDuration = 1000
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Poppy", MenuName = "PoppyRInstant", SpellName = "PoppyRSpellInstant", DangerValue = 4,
                        Slot = SpellSlot.R, Range = 500, Delay = 350, Radius = 100, FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Poppy", MenuName = "PoppyRCharge", SpellName = "PoppyRSpell",
                        MissileName = "PoppyRMissile", DangerValue = 3, Slot = SpellSlot.R, Range = 1150, Delay = 350,
                        Radius = 100, MissileSpeed = 1600,
                        CollisionObjects = new[] { CollisionableObjects.Heroes, CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            #endregion

            #region Quinn

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Quinn", MenuName = "QuinnQ", SpellName = "QuinnQ", MissileName = "QuinnQ",
                        DangerValue = 3, Range = 1050, Radius = 60, MissileSpeed = 1550,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            #endregion Quinn

            #region RekSai

            Spells.Add(
                new SpellData
                    {
                        ChampName = "RekSai", MenuName = "RekSaiQ", SpellName = "RekSaiQBurrowed",
                        MissileName = "RekSaiQBurrowedMis", DangerValue = 2, Range = 1500, Delay = 125, Radius = 65,
                        MissileSpeed = 1950,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "RekSai", MenuName = "RekSaiW", SpellName = "RekSaiWBurrowed", DangerValue = 3,
                        Slot = SpellSlot.W, Delay = 0, Radius = 200, Type = SpellType.Circle
                    });

            #endregion RekSai

            #region Rengar

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Rengar", MenuName = "RengarE", SpellName = "RengarE", MissileName = "RengarEFinal",
                        ExtraMissileNames = new[] { "RengarEFinalMAX" }, DangerValue = 3, Slot = SpellSlot.E, Range = 1000,
                        Radius = 70, MissileSpeed = 1500,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            #endregion Rengar

            #region Riven

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Riven", MenuName = "RivenW", SpellName = "RivenMartyr", DangerValue = 3,
                        Slot = SpellSlot.W, Delay = 0, Radius = 250, Type = SpellType.Circle
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Riven", MenuName = "RivenR", SpellName = "RivenIzunaBlade",
                        MissileName = "RivenWindslashMissileCenter",
                        ExtraMissileNames = new[] { "RivenWindslashMissileLeft", "RivenWindslashMissileRight" },
                        DangerValue = 4, Slot = SpellSlot.R, Range = 1075, Radius = 100, MissileSpeed = 1600,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true, MultipleNumber = 3,
                        MultipleAngle = 10 * (float)Math.PI / 180
                    });

            #endregion Riven

            #region Rumble

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Rumble", MenuName = "RumbleE", SpellName = "RumbleGrenade",
                        MissileName = "RumbleGrenadeMissile", DangerValue = 2, Slot = SpellSlot.E, Range = 950,
                        Radius = 60, MissileSpeed = 2000,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Rumble", MenuName = "RumbleR", SpellName = "RumbleCarpetBomb",
                        MissileName = "RumbleCarpetBombMissile", DangerValue = 4, Slot = SpellSlot.R, Range = 25000,
                        Delay = 380, Radius = 150, MissileSpeed = 1600, MissileOnly = true, MissileDelayed = true,
                        CanBeRemoved = false
                    });

            #endregion Rumble

            #region Ryze

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Ryze", MenuName = "RyzeQ", SpellName = "RyzeQ", MissileName = "RyzeQ",
                        DangerValue = 2, Range = 1000, Radius = 55, MissileSpeed = 1700,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            #endregion Ryze

            #region Sejuani

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Sejuani", MenuName = "SejuaniQ", SpellName = "SejuaniArcticAssault", DangerValue = 3,
                        Range = 650, Delay = 0, Radius = 75, MissileSpeed = 1000,
                        CollisionObjects = new[] { CollisionableObjects.Heroes }
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Sejuani", MenuName = "SejuaniR", SpellName = "SejuaniGlacialPrisonCast",
                        MissileName = "SejuaniGlacialPrison", DangerValue = 4, Slot = SpellSlot.R, Range = 1100,
                        Radius = 110, MissileSpeed = 1600,
                        CollisionObjects = new[] { CollisionableObjects.Heroes, CollisionableObjects.YasuoWall },
                        FixedRange = true, HasEndExplosion = true, RadiusEx = 450
                    });

            #endregion Sejuani

            #region Shen

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Shen", MenuName = "ShenE", SpellName = "ShenE", DangerValue = 3, Slot = SpellSlot.E,
                        Range = 600, Delay = 0, Radius = 50, MissileSpeed = 1200
                    });

            #endregion Shen

            #region Shyvana

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Shyvana", MenuName = "ShyvanaE", SpellName = "ShyvanaFireball",
                        MissileName = "ShyvanaFireballMissile", DangerValue = 2, Slot = SpellSlot.E, Range = 950,
                        Radius = 60, MissileSpeed = 1700, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Shyvana", MenuName = "ShyvanaEDragon", SpellName = "ShyvanaFireballDragon2",
                        MissileName = "ShyvanaFireballDragonFxMissile", DangerValue = 2, Slot = SpellSlot.E, Range = 750,
                        Radius = 70, MissileSpeed = 2000, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        FixedRange = true, MultipleNumber = 5, MultipleAngle = 10 * (float)Math.PI / 180
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Shyvana", MenuName = "ShyvanaR", SpellName = "ShyvanaTransformCast", DangerValue = 3,
                        Slot = SpellSlot.R, Range = 1050, Radius = 160, MissileSpeed = 1100
                    });

            #endregion Shyvana

            #region Sion

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Sion", MenuName = "SionE", SpellName = "SionE", MissileName = "SionEMissile",
                        DangerValue = 3, Slot = SpellSlot.E, Range = 800, Radius = 80, MissileSpeed = 1800,
                        CollisionObjects = new[] { CollisionableObjects.Heroes, CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Sion", MenuName = "SionR", SpellName = "SionR", DangerValue = 3, Slot = SpellSlot.R,
                        Range = 480, Delay = 0, Radius = 120, MissileSpeed = 1000,
                        CollisionObjects = new[] { CollisionableObjects.Heroes }, FixedRange = true
                    });

            #endregion Sion

            #region Sivir

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Sivir", MenuName = "SivirQ", SpellName = "SivirQ", MissileName = "SivirQMissile",
                        DangerValue = 2, Range = 1250, Radius = 90, MissileSpeed = 1350,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Sivir", MenuName = "SivirQReturn", SpellName = "SivirQReturn",
                        MissileName = "SivirQMissileReturn", DangerValue = 2, Range = 25000, Delay = 0, Radius = 100,
                        MissileSpeed = 1350, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        MissileToUnit = true
                    });

            #endregion Sivir

            #region Skarner

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Skarner", MenuName = "SkarnerE", SpellName = "SkarnerFracture",
                        MissileName = "SkarnerFractureMissile", DangerValue = 2, Slot = SpellSlot.E, Range = 1000,
                        Delay = 250, Radius = 60, MissileSpeed = 1400,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true
                    });

            #endregion Skarner

            #region Sona

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Sona", MenuName = "SonaR", SpellName = "SonaR", MissileName = "SonaR",
                        DangerValue = 4, Slot = SpellSlot.R, Range = 1000, Radius = 140, MissileSpeed = 2400,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true
                    });

            #endregion Sona

            #region Soraka

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Soraka", MenuName = "SorakaQ", SpellName = "SorakaQ", MissileName = "SorakaQMissile",
                        Range = 800, Radius = 230, MissileSpeed = 1100, Type = SpellType.Circle,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Soraka", MenuName = "SorakaE", SpellName = "SorakaE", DangerValue = 3,
                        Slot = SpellSlot.E, Range = 910, Delay = 1750, Radius = 250, Type = SpellType.Circle
                    });

            #endregion Soraka

            #region Swain

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Swain", MenuName = "SwainW", SpellName = "SwainShadowGrasp", DangerValue = 3,
                        Slot = SpellSlot.W, Range = 900, Delay = 1100, Radius = 240, Type = SpellType.Circle
                    });

            #endregion Swain

            #region Syndra

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Syndra", MenuName = "SyndraQ", SpellName = "SyndraQ", MissileName = "SyndraQSpell",
                        DangerValue = 2, Range = 800, Delay = 650, Radius = 180, Type = SpellType.Circle,
                        MissileDelayed = true, CanBeRemoved = false
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Syndra", MenuName = "SyndraW", SpellName = "SyndraWCast", DangerValue = 2,
                        Slot = SpellSlot.W, Range = 925, Delay = 200, Radius = 210, MissileSpeed = 1500,
                        Type = SpellType.Circle
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Syndra", MenuName = "SyndraE", SpellName = "SyndraE",
                        ExtraSpellNames = new[] { "SyndraE5" }, DangerValue = 3, Slot = SpellSlot.E, Range = 730,
                        Radius = 40, MissileSpeed = 2500, Type = SpellType.Cone, RadiusEx = 60
                    });

            #endregion Syndra

            #region TahmKench

            Spells.Add(
                new SpellData
                    {
                        ChampName = "TahmKench", MenuName = "TahmKenchQ", SpellName = "TahmKenchQ",
                        MissileName = "TahmKenchQMissile", DangerValue = 3, Range = 900, Radius = 70, MissileSpeed = 2800,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            #endregion TahmKench

            #region Talon

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Talon", MenuName = "TalonW", SpellName = "TalonRake",
                        MissileName = "TalonRakeMissileOne", DangerValue = 2, Slot = SpellSlot.W, Range = 700, Radius = 75,
                        MissileSpeed = 2300, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        FixedRange = true, MultipleNumber = 3, MultipleAngle = 20 * (float)Math.PI / 180
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Talon", MenuName = "TalonWReturn", SpellName = "TalonWReturn",
                        MissileName = "TalonRakeMissileTwo", DangerValue = 2, Slot = SpellSlot.W, Range = 25000, Delay = 0,
                        Radius = 75, MissileSpeed = 1850, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        MissileToUnit = true
                    });

            #endregion Talon

            #region Taliyah

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Taliyah", DangerValue = 2, MissileName = "TaliyahQMis", MissileSpeed = 1450,
                        MenuName = "Threaded Volley", Radius = 100, Range = 1000, FixedRange = true, Delay = 250,
                        Slot = SpellSlot.Q, SpellName = "TaliyahQ", Type = SpellType.Line
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Taliyah", DangerValue = 3, MissileName = "TaliyahWVC", MenuName = "Seismic Shove",
                        Radius = 150, Range = 900, Delay = 1000, Slot = SpellSlot.W, SpellName = "TaliyahWVC",
                        Type = SpellType.Circle
                    });

            #endregion Taliyah

            #region Taric

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Taric", MenuName = "TaricE", SpellName = "TaricE", DangerValue = 2,
                        Slot = SpellSlot.E, Range = 750, Delay = 1000, Radius = 100, FixedRange = true,
                        MissileFromUnit = true
                    });

            #endregion

            #region Thresh

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Thresh", MenuName = "ThreshQ", SpellName = "ThreshQ", MissileName = "ThreshQMissile",
                        DangerValue = 2, Range = 1100, Delay = 500, Radius = 70, MissileSpeed = 1900,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Thresh", MenuName = "ThreshE", SpellName = "ThreshE", MissileName = "ThreshEMissile1",
                        DangerValue = 3, Slot = SpellSlot.E, Range = 1075, Delay = 0, Radius = 110, MissileSpeed = 2000,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true, MissileOnly = true
                    });

            #endregion Thresh

            #region Tristana

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Tristana", MenuName = "TristanaW", SpellName = "TristanaW", Slot = SpellSlot.W,
                        Range = 900, Delay = 300, Radius = 270, MissileSpeed = 1100, Type = SpellType.Circle
                    });

            #endregion Tristana

            #region Tryndamere

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Tryndamere", MenuName = "TryndamereE", SpellName = "TryndamereE", DangerValue = 2,
                        Slot = SpellSlot.E, Range = 660, Delay = 0, Radius = 160, MissileSpeed = 900
                    });

            #endregion Tryndamere

            #region TwistedFate

            Spells.Add(
                new SpellData
                    {
                        ChampName = "TwistedFate", MenuName = "TwistedFateQ", SpellName = "WildCards",
                        MissileName = "SealFateMissile", DangerValue = 2, Range = 1450, Radius = 40, MissileSpeed = 1000,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true, MultipleNumber = 3,
                        MultipleAngle = 28 * (float)Math.PI / 180
                    });

            #endregion TwistedFate

            #region Twitch

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Twitch", MenuName = "TwitchW", SpellName = "TwitchVenomCask",
                        MissileName = "TwitchVenomCaskMissile", DangerValue = 2, Slot = SpellSlot.W, Range = 950,
                        Radius = 285, MissileSpeed = 1400, Type = SpellType.Circle,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Twitch", MenuName = "TwitchR", SpellName = "TwitchSprayAndPrayAttack",
                        MissileName = "TwitchSprayAndPrayAttack", DangerValue = 2, Slot = SpellSlot.R, Range = 1100,
                        Delay = 0, Radius = 60, MissileSpeed = 4000,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true, MissileOnly = true
                    });

            #endregion Twitch

            #region Urgot

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Urgot", MenuName = "UrgotQ", SpellName = "UrgotHeatseekingMissile",
                        MissileName = "UrgotHeatseekingLineMissile", DangerValue = 2, Range = 1000, Delay = 150,
                        Radius = 60, MissileSpeed = 1600,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Urgot", MenuName = "UrgotE", SpellName = "UrgotPlasmaGrenade",
                        MissileName = "UrgotPlasmaGrenadeBoom", DangerValue = 2, Slot = SpellSlot.E, Range = 900,
                        Radius = 250, MissileSpeed = 1500, Type = SpellType.Circle,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }
                    });

            #endregion Urgot

            #region Varus

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Varus", MenuName = "VarusQ", SpellName = "VarusQ", MissileName = "VarusQMissile",
                        DangerValue = 2, Range = 2000, Delay = 0, Radius = 70, MissileSpeed = 1900,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, MissileOnly = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Varus", MenuName = "VarusE", SpellName = "VarusE", MissileName = "VarusEMissile",
                        DangerValue = 2, Slot = SpellSlot.E, Range = 925, Radius = 235, MissileSpeed = 1500,
                        Type = SpellType.Circle, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        DelayEx = 300
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Varus", MenuName = "VarusR", SpellName = "VarusR", MissileName = "VarusRMissile",
                        DangerValue = 3, Slot = SpellSlot.R, Range = 1250, Radius = 120, MissileSpeed = 1950,
                        CollisionObjects = new[] { CollisionableObjects.Heroes, CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            #endregion Varus

            #region Veigar

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Veigar", MenuName = "VeigarQ", SpellName = "VeigarBalefulStrike",
                        MissileName = "VeigarBalefulStrikeMis", DangerValue = 2, Range = 950, Radius = 70,
                        MissileSpeed = 2200, CollisionObjects = new[] { CollisionableObjects.YasuoWall },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Veigar", MenuName = "VeigarW", SpellName = "VeigarDarkMatter", DangerValue = 2,
                        Slot = SpellSlot.W, Range = 900, Delay = 1250, Radius = 225, Type = SpellType.Circle
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Veigar", MenuName = "VeigarE", SpellName = "VeigarEventHorizon", DangerValue = 3,
                        Slot = SpellSlot.E, Range = 720, Delay = 800, Radius = 390, Type = SpellType.Ring, RadiusEx = 300,
                        ExtraDuration = 3000
                    });

            #endregion Veigar

            #region Velkoz

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Velkoz", MenuName = "VelkozQ", SpellName = "VelkozQ", MissileName = "VelkozQMissile",
                        DangerValue = 2, Range = 1100, Radius = 50, MissileSpeed = 1300,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Velkoz", MenuName = "VelkozQSplit", SpellName = "VelkozQSplit",
                        MissileName = "VelkozQMissileSplit", DangerValue = 2, Range = 1100, Delay = 0, Radius = 45,
                        MissileSpeed = 2100,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Velkoz", MenuName = "VelkozW", SpellName = "VelkozW", MissileName = "VelkozWMissile",
                        DangerValue = 2, Slot = SpellSlot.W, Range = 1170, Radius = 88, MissileSpeed = 1700
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Velkoz", MenuName = "VelkozE", SpellName = "VelkozE", MissileName = "VelkozEMissile",
                        DangerValue = 3, Slot = SpellSlot.E, Range = 800, Radius = 225, MissileSpeed = 1500,
                        Type = SpellType.Circle
                    });

            #endregion Velkoz

            #region Vi

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Vi", MenuName = "ViQ", SpellName = "ViQ", MissileName = "ViQMissile", DangerValue = 3,
                        Range = 2000, Delay = 0, Radius = 90, MissileSpeed = 1500,
                        CollisionObjects = new[] { CollisionableObjects.Heroes }, MissileOnly = true
                    });

            #endregion Vi

            #region Viktor

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Viktor", MenuName = "ViktorW", SpellName = "ViktorGravitonField", DangerValue = 3,
                        Slot = SpellSlot.W, Range = 700, Delay = 1500, Radius = 300, Type = SpellType.Circle
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Viktor", MenuName = "ViktorE", SpellName = "ViktorDeathRay",
                        MissileName = "ViktorDeathRayMissile", ExtraMissileNames = new[] { "ViktorEAugMissile" },
                        DangerValue = 2, Slot = SpellSlot.E, Range = 25000, Delay = 0, Radius = 80, MissileSpeed = 1050,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, MissileOnly = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Viktor", MenuName = "ViktorEExplosion", SpellName = "ViktorEExplosion",
                        MissileName = "ViktorEAugParticle", DangerValue = 2, Slot = SpellSlot.E, Range = 25000,
                        Delay = 300, Radius = 80, MissileSpeed = 1500, MissileDelayed = true, CanBeRemoved = false
                    });

            #endregion Viktor

            #region Vladimir

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Vladimir", MenuName = "VladimirR", SpellName = "VladimirHemoplague", DangerValue = 3,
                        Slot = SpellSlot.R, Range = 700, Delay = 0, Radius = 375, Type = SpellType.Circle
                    });

            #endregion Vladimir

            #region Xerath

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Xerath", MenuName = "XerathQ", SpellName = "XerathArcanopulse2", DangerValue = 2,
                        Range = 25000, Delay = 500, Radius = 100
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Xerath", MenuName = "XerathW", SpellName = "XerathArcaneBarrage2", DangerValue = 2,
                        Slot = SpellSlot.W, Range = 1100, Delay = 750, Radius = 250, Type = SpellType.Circle
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Xerath", MenuName = "XerathE", SpellName = "XerathMageSpear",
                        MissileName = "XerathMageSpearMissile", DangerValue = 3, Slot = SpellSlot.E, Range = 1150,
                        Radius = 60, MissileSpeed = 1400,
                        CollisionObjects =
                            new[]
                                {
                                    CollisionableObjects.Heroes, CollisionableObjects.Minions,
                                    CollisionableObjects.YasuoWall
                                },
                        FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Xerath", MenuName = "XerathR", SpellName = "XerathRMissileWrapper",
                        MissileName = "XerathLocusPulse", DangerValue = 3, Slot = SpellSlot.R, Range = 25000, Delay = 650,
                        Radius = 200, Type = SpellType.Circle, MissileDelayed = true
                    });

            #endregion Xerath

            #region Yasuo

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Yasuo", MenuName = "YasuoQ", SpellName = "YasuoQ",
                        ExtraSpellNames = new[] { "YasuoQ2" }, DangerValue = 2, Range = 520, Delay = 400, Radius = 55,
                        FixedRange = true, Invert = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Yasuo", MenuName = "YasuoQ3", SpellName = "YasuoQ3", MissileName = "YasuoQ3Mis",
                        DangerValue = 3, Range = 1100, Delay = 300, Radius = 90, MissileSpeed = 1200,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true, Invert = true
                    });

            #endregion Yasuo

            #region Yorick

            //TODO: Yorick W and E

            #endregion Yorick

            #region Zac

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Zac", DangerValue = 3, MissileName = "ZacQ", MenuName = "Stretching Strike",
                        Radius = 120, Range = 550, Delay = 500, Slot = SpellSlot.Q, SpellName = "ZacQ",
                        Type = SpellType.Line
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Zac", DangerValue = 3, MenuName = "Elastic Slingshot", MissileSpeed = 1000,
                        Radius = 300, Range = 1800, Delay = 250, Slot = SpellSlot.E, SpellName = "ZacE",
                        Type = SpellType.Circle
                    });

            //TODO: Zac R

            #endregion Zac

            #region Zed

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Zed", MenuName = "ZedQ", SpellName = "ZedQ", MissileName = "ZedQMissile",
                        DangerValue = 3, Range = 925, Radius = 50, MissileSpeed = 1700,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, FixedRange = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Zed", MenuName = "ZedE", SpellName = "ZedE", DangerValue = 2, Slot = SpellSlot.E,
                        Delay = 0, Radius = 290
                    });

            #endregion Zed

            #region Ziggs

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Ziggs", MenuName = "ZiggsQ", SpellName = "ZiggsQ", MissileName = "ZiggsQSpell",
                        DangerValue = 2, Range = 850, Radius = 125, MissileSpeed = 1700, Type = SpellType.Circle
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Ziggs", MenuName = "ZiggsQBounce", SpellName = "ZiggsQBounce",
                        MissileName = "ZiggsQSpell2", ExtraMissileNames = new[] { "ZiggsQSpell3" }, DangerValue = 2,
                        Range = 1100, Delay = 500, Radius = 225, MissileSpeed = 1600, Type = SpellType.Circle,
                        MissileDelayed = true
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Ziggs", MenuName = "ZiggsW", SpellName = "ZiggsW", MissileName = "ZiggsW",
                        DangerValue = 2, Slot = SpellSlot.W, Range = 1000, Radius = 275, MissileSpeed = 1750,
                        Type = SpellType.Circle
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Ziggs", MenuName = "ZiggsE", SpellName = "ZiggsE", MissileName = "ZiggsE2",
                        Slot = SpellSlot.E, Range = 900, Radius = 225, MissileSpeed = 1550, Type = SpellType.Circle
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Ziggs", MenuName = "ZiggsR", SpellName = "ZiggsR", MissileName = "ZiggsRBoom",
                        DangerValue = 4, Slot = SpellSlot.R, Range = 5300, Delay = 400, Radius = 500, MissileSpeed = 1500,
                        Type = SpellType.Circle
                    });

            #endregion Ziggs

            #region Zilean

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Zilean", MenuName = "ZileanQ", SpellName = "ZileanQ", MissileName = "ZileanQMissile",
                        ToggleName = "Zilean_.+_Q_TimeBombGround", DangerValue = 3, Range = 900, Delay = 250, Radius = 150,
                        MissileSpeed = 2000, Type = SpellType.Circle,
                        CollisionObjects = new[] { CollisionableObjects.YasuoWall }, DelayEx = 250, ExtraDuration = 3000,
                        RadiusEx = 350
                    });

            #endregion Zilean

            #region Zyra

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Zyra", DangerValue = 3, MenuName = "Grasping Roots", MissileName = "ZyraEMissile",
                        MissileSpeed = 1150, Radius = 90, Range = 1150, Delay = 250, Slot = SpellSlot.E,
                        SpellName = "ZyraE", Type = SpellType.Line
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Zyra", DangerValue = 2, MissileName = "ZyraQ", MenuName = "Deadly Bloom",
                        Radius = 140, Range = 800, Delay = 850, Slot = SpellSlot.Q, SpellName = "ZyraQ",
                        Type = SpellType.Line, Perpendicular = true, RadiusEx = 400
                    });

            Spells.Add(
                new SpellData
                    {
                        ChampName = "Zyra", DangerValue = 4, MissileName = "ZyraBrambleZone", MenuName = "Stranglethorns",
                        Radius = 525, Range = 700, ExtraDuration = 2000, Delay = 500, Slot = SpellSlot.R,
                        SpellName = "ZyraR", ExtraSpellNames = new[] { "ZyraBrambleZone" }, Type = SpellType.Circle
                    });

            #endregion Zyra
            */
        }

        #endregion
    }
}