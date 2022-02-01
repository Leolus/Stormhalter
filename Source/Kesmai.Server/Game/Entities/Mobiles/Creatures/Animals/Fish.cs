using System.IO;

namespace Kesmai.Server.Game
{
	public partial class Fish : AnimalEntity
	{
		public Fish()
		{
			Name = "fish";
			Body = 13;

			Alignment = Alignment.Chaotic;
			
			VisibilityDistance = 0;

			CanSwim = true;
		}
		
		protected override void OnCreate()
		{
			base.OnCreate();

			_brain = new CombatAI(this);
		}

		public override int GetNearbySound() => 0;
		public override int GetAttackSound() => 0;
		public override int GetDeathSound() => 182;
	}
}