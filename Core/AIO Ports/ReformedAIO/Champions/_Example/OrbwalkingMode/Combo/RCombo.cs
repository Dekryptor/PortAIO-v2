using EloBuddy; 
using LeagueSharp.Common; 
namespace ReformedAIO.Champions._Example.OrbwalkingMode.Combo
{
    using System;

    using LeagueSharp;
    using LeagueSharp.Common;

    using ReformedAIO.Champions._Example.Core.Spells;

    using RethoughtLib.FeatureSystem.Implementations;

    internal sealed class RCombo : OrbwalkingChild
    {
        public override string Name { get; set; } = "R";

        private readonly RSpell spell;

        public RCombo(RSpell spell)
        {
            this.spell = spell;
        }

        private AIHeroClient Target => TargetSelector.GetTarget(spell.Spell.Range, TargetSelector.DamageType.Physical);

        private void OnUpdate(EventArgs args)
        {
            if (!CheckGuardians()
                || Target == null
                || Menu.Item("Example.Combo.R.Mana").GetValue<Slider>().Value > ObjectManager.Player.ManaPercent)
            {
                return;
            }


        }

        protected override void OnDisable(object sender, FeatureBaseEventArgs eventArgs)
        {
            base.OnDisable(sender, eventArgs);

            Game.OnUpdate -= OnUpdate;
        }

        protected override void OnEnable(object sender, FeatureBaseEventArgs eventArgs)
        {
            base.OnEnable(sender, eventArgs);

            Game.OnUpdate += OnUpdate;
        }

        protected override void OnLoad(object sender, FeatureBaseEventArgs eventArgs)
        {
            base.OnLoad(sender, eventArgs);


            Menu.AddItem(new MenuItem("Example.Combo.R.Mana", "Min Mana %").SetValue(new Slider(0, 0, 100)));
        }
    }
}
