using System;
using System.Collections.Generic;
using Engine;
using Engine.Graphics;

namespace Game
{
	public abstract class AlphaTrueColorBlock : TrueColorBlock
	{
		public new string DefaultCategory = "Alpha Colored";
		public new string DefaultDescription = "Alpha True Color Block";
		public override void GenerateTerrainVertices(BlockGeometryGenerator generator, TerrainGeometrySubsets geometry, int value, int x, int y, int z)
		{
			generator.GenerateCubeVertices(this, value, x, y, z, new Color(AlphaTrueColorBlock.GetColor(value)), geometry.TransparentSubsetsByFace);
		}
		public override IEnumerable<int> GetCreativeValues()
		{
			for (int i = 0; i < 4096; i ++)
			{
				yield return AlphaTrueColorBlock.SetColor(i >> 8 << 20 | (i >> 4 & 15) << 12 | (i & 15) << 4);
			}
			yield break;
		}
		public new static uint GetColor(int value)
		{
			return (uint)((TerrainData.ExtractContents(value) - 565 & 63) << 18 | TerrainData.ExtractData(value)) | 1u << 31;
		}
		public new static int SetColor(int color)
		{
			return TrueColorBlock.SetColor(color) + 64;
		}
	}
	public class AlphaTrueColorBlock1 : AlphaTrueColorBlock
	{
		public const int Index = 565;
	}
	public class AlphaTrueColorBlock2 : AlphaTrueColorBlock
	{
		public const int Index = 566;
	}
	public class AlphaTrueColorBlock3 : AlphaTrueColorBlock
	{
		public const int Index = 567;
	}
	public class AlphaTrueColorBlock4 : AlphaTrueColorBlock
	{
		public const int Index = 568;
	}
	public class AlphaTrueColorBlock5 : AlphaTrueColorBlock
	{
		public const int Index = 569;
	}
	public class AlphaTrueColorBlock6 : AlphaTrueColorBlock
	{
		public const int Index = 570;
	}
	public class AlphaTrueColorBlock7 : AlphaTrueColorBlock
	{
		public const int Index = 571;
	}
	public class AlphaTrueColorBlock8 : AlphaTrueColorBlock
	{
		public const int Index = 572;
	}
	public class AlphaTrueColorBlock9 : AlphaTrueColorBlock
	{
		public const int Index = 573;
	}
	public class AlphaTrueColorBlock10 : AlphaTrueColorBlock
	{
		public const int Index = 574;
	}
	public class AlphaTrueColorBlock11 : AlphaTrueColorBlock
	{
		public const int Index = 575;
	}
	public class AlphaTrueColorBlock12 : AlphaTrueColorBlock
	{
		public const int Index = 576;
	}
	public class AlphaTrueColorBlock13 : AlphaTrueColorBlock
	{
		public const int Index = 577;
	}
	public class AlphaTrueColorBlock14 : AlphaTrueColorBlock
	{
		public const int Index = 578;
	}
	public class AlphaTrueColorBlock15 : AlphaTrueColorBlock
	{
		public const int Index = 579;
	}
	public class AlphaTrueColorBlock16 : AlphaTrueColorBlock
	{
		public const int Index = 580;
	}
	public class AlphaTrueColorBlock17 : AlphaTrueColorBlock
	{
		public const int Index = 581;
	}
	public class AlphaTrueColorBlock18 : AlphaTrueColorBlock
	{
		public const int Index = 582;
	}
	public class AlphaTrueColorBlock19 : AlphaTrueColorBlock
	{
		public const int Index = 583;
	}
	public class AlphaTrueColorBlock20 : AlphaTrueColorBlock
	{
		public const int Index = 584;
	}
	public class AlphaTrueColorBlock21 : AlphaTrueColorBlock
	{
		public const int Index = 585;
	}
	public class AlphaTrueColorBlock22 : AlphaTrueColorBlock
	{
		public const int Index = 586;
	}
	public class AlphaTrueColorBlock23 : AlphaTrueColorBlock
	{
		public const int Index = 587;
	}
	public class AlphaTrueColorBlock24 : AlphaTrueColorBlock
	{
		public const int Index = 588;
	}
	public class AlphaTrueColorBlock25 : AlphaTrueColorBlock
	{
		public const int Index = 589;
	}
	public class AlphaTrueColorBlock26 : AlphaTrueColorBlock
	{
		public const int Index = 590;
	}
	public class AlphaTrueColorBlock27 : AlphaTrueColorBlock
	{
		public const int Index = 591;
	}
	public class AlphaTrueColorBlock28 : AlphaTrueColorBlock
	{
		public const int Index = 592;
	}
	public class AlphaTrueColorBlock29 : AlphaTrueColorBlock
	{
		public const int Index = 593;
	}
	public class AlphaTrueColorBlock30 : AlphaTrueColorBlock
	{
		public const int Index = 594;
	}
	public class AlphaTrueColorBlock31 : AlphaTrueColorBlock
	{
		public const int Index = 595;
	}
	public class AlphaTrueColorBlock32 : AlphaTrueColorBlock
	{
		public const int Index = 596;
	}
	public class AlphaTrueColorBlock33 : AlphaTrueColorBlock
	{
		public const int Index = 597;
	}
	public class AlphaTrueColorBlock34 : AlphaTrueColorBlock
	{
		public const int Index = 598;
	}
	public class AlphaTrueColorBlock35 : AlphaTrueColorBlock
	{
		public const int Index = 599;
	}
	public class AlphaTrueColorBlock36 : AlphaTrueColorBlock
	{
		public const int Index = 600;
	}
	public class AlphaTrueColorBlock37 : AlphaTrueColorBlock
	{
		public const int Index = 601;
	}
	public class AlphaTrueColorBlock38 : AlphaTrueColorBlock
	{
		public const int Index = 602;
	}
	public class AlphaTrueColorBlock39 : AlphaTrueColorBlock
	{
		public const int Index = 603;
	}
	public class AlphaTrueColorBlock40 : AlphaTrueColorBlock
	{
		public const int Index = 604;
	}
	public class AlphaTrueColorBlock41 : AlphaTrueColorBlock
	{
		public const int Index = 605;
	}
	public class AlphaTrueColorBlock42 : AlphaTrueColorBlock
	{
		public const int Index = 606;
	}
	public class AlphaTrueColorBlock43 : AlphaTrueColorBlock
	{
		public const int Index = 607;
	}
	public class AlphaTrueColorBlock44 : AlphaTrueColorBlock
	{
		public const int Index = 608;
	}
	public class AlphaTrueColorBlock45 : AlphaTrueColorBlock
	{
		public const int Index = 609;
	}
	public class AlphaTrueColorBlock46 : AlphaTrueColorBlock
	{
		public const int Index = 610;
	}
	public class AlphaTrueColorBlock47 : AlphaTrueColorBlock
	{
		public const int Index = 611;
	}
	public class AlphaTrueColorBlock48 : AlphaTrueColorBlock
	{
		public const int Index = 612;
	}
	public class AlphaTrueColorBlock49 : AlphaTrueColorBlock
	{
		public const int Index = 613;
	}
	public class AlphaTrueColorBlock50 : AlphaTrueColorBlock
	{
		public const int Index = 614;
	}
	public class AlphaTrueColorBlock51 : AlphaTrueColorBlock
	{
		public const int Index = 615;
	}
	public class AlphaTrueColorBlock52 : AlphaTrueColorBlock
	{
		public const int Index = 616;
	}
	public class AlphaTrueColorBlock53 : AlphaTrueColorBlock
	{
		public const int Index = 617;
	}
	public class AlphaTrueColorBlock54 : AlphaTrueColorBlock
	{
		public const int Index = 618;
	}
	public class AlphaTrueColorBlock55 : AlphaTrueColorBlock
	{
		public const int Index = 619;
	}
	public class AlphaTrueColorBlock56 : AlphaTrueColorBlock
	{
		public const int Index = 620;
	}
	public class AlphaTrueColorBlock57 : AlphaTrueColorBlock
	{
		public const int Index = 621;
	}
	public class AlphaTrueColorBlock58 : AlphaTrueColorBlock
	{
		public const int Index = 622;
	}
	public class AlphaTrueColorBlock59 : AlphaTrueColorBlock
	{
		public const int Index = 623;
	}
	public class AlphaTrueColorBlock60 : AlphaTrueColorBlock
	{
		public const int Index = 624;
	}
	public class AlphaTrueColorBlock61 : AlphaTrueColorBlock
	{
		public const int Index = 625;
	}
	public class AlphaTrueColorBlock62 : AlphaTrueColorBlock
	{
		public const int Index = 626;
	}
	public class AlphaTrueColorBlock63 : AlphaTrueColorBlock
	{
		public const int Index = 627;
	}
	public class AlphaTrueColorBlock64 : AlphaTrueColorBlock
	{
		public const int Index = 628;
	}
}