namespace Role_Playing_Game;

public class Character
{
	public int Level { get; set; } = 1;
	public int Experience { get; set; }
	public int ExperienceToNextLevel { get; set; } = 10;
	public int Health { get; set; } = 5;
	public int MaxHealth => Level * 5;
	public int Gold { get; set; }
	public int Damage { get; set; } = 1;

	public int I { get; set; }
	public int J { get; set; }

	public int TileI => (I < 0 ? I - 6 : I) / 7;
	public int TileJ => (J < 0 ? J - 3 : J) / 4;

	private string[]? _mapAnimation;
	public string[]? MapAnimation
	{
		get => _mapAnimation;
		set
		{
			_mapAnimation = value;
			_mapAnimationFrame = 0;
		}
	}

	private int _mapAnimationFrame;
	public int MapAnimationFrame
	{
		get => _mapAnimationFrame;
		set
		{
			_mapAnimationFrame = value;
			Moved = false;
			if (_mapAnimationFrame >= MapAnimation?.Length)
			{
				MapAnimation = MapAnimation switch
				{
					Sprites.RunUp => Sprites.IdleUp,
					Sprites.RunDown => Sprites.IdleDown,
					Sprites.RunLeft => Sprites.IdleLeft,
					Sprites.RunRight => Sprites.IdleRight,
					_ => MapAnimation
				};
				Moved = MapAnimation != null;
				_mapAnimationFrame = 0;
			}
		}
	}

	public bool IsIdle => MapAnimation is Sprites.IdleDown or Sprites.IdleUp or Sprites.IdleLeft or Sprites.IdleRight;

	public string Render => MapAnimation is not null && _mapAnimationFrame < MapAnimation.Length
		? MapAnimation[_mapAnimationFrame]
		: @" __O__ " + '\n' +
		  @"   |   " + '\n' +
		  @"   |   " + '\n' +
		  @"  | |  ";

	public bool Moved { get; set; } = false;
}
