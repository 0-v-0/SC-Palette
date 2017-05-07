using System;
using System.Collections.Generic;
using Engine;
using Engine.Graphics;

namespace Game
{
	public abstract class TrueColorBlock : CubeBlock
	{
		private static readonly int[] staticCells = new int[]
		{
			16777215,
			12632319,
			12640511,
			12648447,
			12648384,
			16777152,
			16761024,
			16761087,
			14737632,
			8421631,
			8438015,
			8454143,
			8454016,
			16777088,
			16744576,
			16744703,
			12632256,
			255,
			33023,
			65535,
			65280,
			16776960,
			16711680,
			16711935,
			8421504,
			192,
			16576,
			49344,
			49152,
			12632064,
			12582912,
			12583104,
			4210752,
			128,
			16512,
			32896,
			32768,
			8421376,
			8388608,
			8388736,
			0,
			64,
			4210816,
			16448,
			16384,
			4210688,
			4194304,
			4194368
		};
		public override void GenerateTerrainVertices(BlockGeometryGenerator generator, TerrainGeometrySubsets geometry, int value, int x, int y, int z)
		{
			generator.GenerateCubeVertices(this, value, x, y, z, new Color(TrueColorBlock.GetColor(value)), geometry.OpaqueSubsetsByFace);
		}
		public override void DrawBlock(PrimitivesRenderer3D primitivesRenderer, int value, float size, ref Matrix matrix, DrawBlockEnvironmentData environmentData)
		{
			Color color = new Color(TrueColorBlock.GetColor(value));
			BlocksManager.DrawCubeBlock(primitivesRenderer, value, new Vector3(size), ref matrix, color, color, environmentData);
		}
		/*public override IEnumerable<int> GetCreativeValues()
		{
			List<int> list = new List<int>();
			for (int i = 0; i < 8; i++)
			{
				list.Add(TerrainData.MakeBlockValue(18, 0, i));
			}
			return list;
		}*/
		public override IEnumerable<int> GetCreativeValues()
		{
			for (int i = 0; i < 4096; i ++)
			{
				yield return TrueColorBlock.SetColor(i >> 8 << 20 | (i >> 4 & 15) << 12 | (i & 15) << 4);
			}
			yield break;
		}
		public override void GetDropValues(SubsystemTerrain terrain, int oldValue, int newValue, int toolLevel, List<BlockDropValue> dropValues, out bool showDebris)
		{
			dropValues.Add(new BlockDropValue
			{
				Value = TerrainData.MakeBlockValue(this.BlockIndex, 0, TerrainData.ExtractData(oldValue)),
				Count = 1
			});
			showDebris = true;
		}
		public override BlockDebrisParticleSystem CreateDebrisParticleSystem(SubsystemTerrain terrain, Vector3 position, int value, float strength)
		{
			return new BlockDebrisParticleSystem(terrain, position, strength, this.DestructionDebrisScale, new Color(TrueColorBlock.GetColor(value)), this.GetFaceTextureSlot(0, value));
		}
		public override string GetDisplayName(SubsystemTerrain subsystemTerrain, int value)
		{
			return this.DefaultDisplayName + " #" + (TrueColorBlock.GetColor(value) & 16777215u).ToString("x6");
		}
		public static uint GetColor(int value)
		{
			return (uint)((TerrainData.ExtractContents(value) - 501 & 63) << 18 | TerrainData.ExtractData(value));
		}
		public static int SetColor(int color)
		{
			return TerrainData.MakeBlockValue((color >> 18 & 63) + 501, 0, color);
		}
	}
	public class TrueColorBlock1 : TrueColorBlock
	{
		public const int Index = 501;
	}
	public class TrueColorBlock2 : TrueColorBlock
	{
		public const int Index = 502;
	}
	public class TrueColorBlock3 : TrueColorBlock
	{
		public const int Index = 503;
	}
	public class TrueColorBlock4 : TrueColorBlock
	{
		public const int Index = 504;
	}
	public class TrueColorBlock5 : TrueColorBlock
	{
		public const int Index = 505;
	}
	public class TrueColorBlock6 : TrueColorBlock
	{
		public const int Index = 506;
	}
	public class TrueColorBlock7 : TrueColorBlock
	{
		public const int Index = 507;
	}
	public class TrueColorBlock8 : TrueColorBlock
	{
		public const int Index = 508;
	}
	public class TrueColorBlock9 : TrueColorBlock
	{
		public const int Index = 509;
	}
	public class TrueColorBlock10 : TrueColorBlock
	{
		public const int Index = 510;
	}
	public class TrueColorBlock11 : TrueColorBlock
	{
		public const int Index = 511;
	}
	public class TrueColorBlock12 : TrueColorBlock
	{
		public const int Index = 512;
	}
	public class TrueColorBlock13 : TrueColorBlock
	{
		public const int Index = 513;
	}
	public class TrueColorBlock14 : TrueColorBlock
	{
		public const int Index = 514;
	}
	public class TrueColorBlock15 : TrueColorBlock
	{
		public const int Index = 515;
	}
	public class TrueColorBlock16 : TrueColorBlock
	{
		public const int Index = 516;
	}
	public class TrueColorBlock17 : TrueColorBlock
	{
		public const int Index = 517;
	}
	public class TrueColorBlock18 : TrueColorBlock
	{
		public const int Index = 518;
	}
	public class TrueColorBlock19 : TrueColorBlock
	{
		public const int Index = 519;
	}
	public class TrueColorBlock20 : TrueColorBlock
	{
		public const int Index = 520;
	}
	public class TrueColorBlock21 : TrueColorBlock
	{
		public const int Index = 521;
	}
	public class TrueColorBlock22 : TrueColorBlock
	{
		public const int Index = 522;
	}
	public class TrueColorBlock23 : TrueColorBlock
	{
		public const int Index = 523;
	}
	public class TrueColorBlock24 : TrueColorBlock
	{
		public const int Index = 524;
	}
	public class TrueColorBlock25 : TrueColorBlock
	{
		public const int Index = 525;
	}
	public class TrueColorBlock26 : TrueColorBlock
	{
		public const int Index = 526;
	}
	public class TrueColorBlock27 : TrueColorBlock
	{
		public const int Index = 527;
	}
	public class TrueColorBlock28 : TrueColorBlock
	{
		public const int Index = 528;
	}
	public class TrueColorBlock29 : TrueColorBlock
	{
		public const int Index = 529;
	}
	public class TrueColorBlock30 : TrueColorBlock
	{
		public const int Index = 530;
	}
	public class TrueColorBlock31 : TrueColorBlock
	{
		public const int Index = 531;
	}
	public class TrueColorBlock32 : TrueColorBlock
	{
		public const int Index = 532;
	}
	public class TrueColorBlock33 : TrueColorBlock
	{
		public const int Index = 533;
	}
	public class TrueColorBlock34 : TrueColorBlock
	{
		public const int Index = 534;
	}
	public class TrueColorBlock35 : TrueColorBlock
	{
		public const int Index = 535;
	}
	public class TrueColorBlock36 : TrueColorBlock
	{
		public const int Index = 536;
	}
	public class TrueColorBlock37 : TrueColorBlock
	{
		public const int Index = 537;
	}
	public class TrueColorBlock38 : TrueColorBlock
	{
		public const int Index = 538;
	}
	public class TrueColorBlock39 : TrueColorBlock
	{
		public const int Index = 539;
	}
	public class TrueColorBlock40 : TrueColorBlock
	{
		public const int Index = 540;
	}
	public class TrueColorBlock41 : TrueColorBlock
	{
		public const int Index = 541;
	}
	public class TrueColorBlock42 : TrueColorBlock
	{
		public const int Index = 542;
	}
	public class TrueColorBlock43 : TrueColorBlock
	{
		public const int Index = 543;
	}
	public class TrueColorBlock44 : TrueColorBlock
	{
		public const int Index = 544;
	}
	public class TrueColorBlock45 : TrueColorBlock
	{
		public const int Index = 545;
	}
	public class TrueColorBlock46 : TrueColorBlock
	{
		public const int Index = 546;
	}
	public class TrueColorBlock47 : TrueColorBlock
	{
		public const int Index = 547;
	}
	public class TrueColorBlock48 : TrueColorBlock
	{
		public const int Index = 548;
	}
	public class TrueColorBlock49 : TrueColorBlock
	{
		public const int Index = 549;
	}
	public class TrueColorBlock50 : TrueColorBlock
	{
		public const int Index = 550;
	}
	public class TrueColorBlock51 : TrueColorBlock
	{
		public const int Index = 551;
	}
	public class TrueColorBlock52 : TrueColorBlock
	{
		public const int Index = 552;
	}
	public class TrueColorBlock53 : TrueColorBlock
	{
		public const int Index = 553;
	}
	public class TrueColorBlock54 : TrueColorBlock
	{
		public const int Index = 554;
	}
	public class TrueColorBlock55 : TrueColorBlock
	{
		public const int Index = 555;
	}
	public class TrueColorBlock56 : TrueColorBlock
	{
		public const int Index = 556;
	}
	public class TrueColorBlock57 : TrueColorBlock
	{
		public const int Index = 557;
	}
	public class TrueColorBlock58 : TrueColorBlock
	{
		public const int Index = 558;
	}
	public class TrueColorBlock59 : TrueColorBlock
	{
		public const int Index = 559;
	}
	public class TrueColorBlock60 : TrueColorBlock
	{
		public const int Index = 560;
	}
	public class TrueColorBlock61 : TrueColorBlock
	{
		public const int Index = 561;
	}
	public class TrueColorBlock62 : TrueColorBlock
	{
		public const int Index = 562;
	}
	public class TrueColorBlock63 : TrueColorBlock
	{
		public const int Index = 563;
	}
	public class TrueColorBlock64 : TrueColorBlock
	{
		public const int Index = 564;
	}
}