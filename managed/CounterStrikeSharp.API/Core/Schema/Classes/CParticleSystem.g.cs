// <auto-generated />
#nullable enable
#pragma warning disable CS1591

using System;
using System.Diagnostics;
using System.Drawing;
using CounterStrikeSharp;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Entities;
using CounterStrikeSharp.API.Modules.Memory;
using CounterStrikeSharp.API.Modules.Utils;
using CounterStrikeSharp.API.Core.Attributes;

namespace CounterStrikeSharp.API.Core;

public partial class CParticleSystem : CBaseModelEntity
{
    public CParticleSystem (IntPtr pointer) : base(pointer) {}

	// m_szSnapshotFileName
	[SchemaMember("CParticleSystem", "m_szSnapshotFileName")]
	public string SnapshotFileName
	{
		get { return Schema.GetString(this.Handle, "CParticleSystem", "m_szSnapshotFileName"); }
		set { Schema.SetString(this.Handle, "CParticleSystem", "m_szSnapshotFileName", value); }
	}

	// m_bActive
	[SchemaMember("CParticleSystem", "m_bActive")]
	public ref bool Active => ref Schema.GetRef<bool>(this.Handle, "CParticleSystem", "m_bActive");

	// m_bFrozen
	[SchemaMember("CParticleSystem", "m_bFrozen")]
	public ref bool Frozen => ref Schema.GetRef<bool>(this.Handle, "CParticleSystem", "m_bFrozen");

	// m_flFreezeTransitionDuration
	[SchemaMember("CParticleSystem", "m_flFreezeTransitionDuration")]
	public ref float FreezeTransitionDuration => ref Schema.GetRef<float>(this.Handle, "CParticleSystem", "m_flFreezeTransitionDuration");

	// m_nStopType
	[SchemaMember("CParticleSystem", "m_nStopType")]
	public ref Int32 StopType => ref Schema.GetRef<Int32>(this.Handle, "CParticleSystem", "m_nStopType");

	// m_bAnimateDuringGameplayPause
	[SchemaMember("CParticleSystem", "m_bAnimateDuringGameplayPause")]
	public ref bool AnimateDuringGameplayPause => ref Schema.GetRef<bool>(this.Handle, "CParticleSystem", "m_bAnimateDuringGameplayPause");

	// m_iEffectIndex
	[SchemaMember("CParticleSystem", "m_iEffectIndex")]
	public CStrongHandle<InfoForResourceTypeIParticleSystemDefinition> EffectIndex => Schema.GetDeclaredClass<CStrongHandle<InfoForResourceTypeIParticleSystemDefinition>>(this.Handle, "CParticleSystem", "m_iEffectIndex");

	// m_flStartTime
	[SchemaMember("CParticleSystem", "m_flStartTime")]
	public ref float StartTime => ref Schema.GetRef<float>(this.Handle, "CParticleSystem", "m_flStartTime");

	// m_flPreSimTime
	[SchemaMember("CParticleSystem", "m_flPreSimTime")]
	public ref float PreSimTime => ref Schema.GetRef<float>(this.Handle, "CParticleSystem", "m_flPreSimTime");

	// m_vServerControlPoints
	[SchemaMember("CParticleSystem", "m_vServerControlPoints")]
	public Span<Vector> ServerControlPoints => Schema.GetFixedArray<Vector>(this.Handle, "CParticleSystem", "m_vServerControlPoints", 4);

	// m_iServerControlPointAssignments
	[SchemaMember("CParticleSystem", "m_iServerControlPointAssignments")]
	public Span<byte> ServerControlPointAssignments => Schema.GetFixedArray<byte>(this.Handle, "CParticleSystem", "m_iServerControlPointAssignments", 4);

	// m_hControlPointEnts
	[SchemaMember("CParticleSystem", "m_hControlPointEnts")]
	public Span<CHandle<CBaseEntity>> ControlPointEnts => Schema.GetFixedArray<CHandle<CBaseEntity>>(this.Handle, "CParticleSystem", "m_hControlPointEnts", 64);

	// m_bNoSave
	[SchemaMember("CParticleSystem", "m_bNoSave")]
	public ref bool NoSave => ref Schema.GetRef<bool>(this.Handle, "CParticleSystem", "m_bNoSave");

	// m_bNoFreeze
	[SchemaMember("CParticleSystem", "m_bNoFreeze")]
	public ref bool NoFreeze => ref Schema.GetRef<bool>(this.Handle, "CParticleSystem", "m_bNoFreeze");

	// m_bNoRamp
	[SchemaMember("CParticleSystem", "m_bNoRamp")]
	public ref bool NoRamp => ref Schema.GetRef<bool>(this.Handle, "CParticleSystem", "m_bNoRamp");

	// m_bStartActive
	[SchemaMember("CParticleSystem", "m_bStartActive")]
	public ref bool StartActive => ref Schema.GetRef<bool>(this.Handle, "CParticleSystem", "m_bStartActive");

	// m_iszEffectName
	[SchemaMember("CParticleSystem", "m_iszEffectName")]
	public string EffectName
	{
		get { return Schema.GetUtf8String(this.Handle, "CParticleSystem", "m_iszEffectName"); }
		set { Schema.SetString(this.Handle, "CParticleSystem", "m_iszEffectName", value); }
	}

	// m_iszControlPointNames
	[SchemaMember("CParticleSystem", "m_iszControlPointNames")]
	public Span<string> ControlPointNames => Schema.GetFixedArray<string>(this.Handle, "CParticleSystem", "m_iszControlPointNames", 64);

	// m_nDataCP
	[SchemaMember("CParticleSystem", "m_nDataCP")]
	public ref Int32 DataCP => ref Schema.GetRef<Int32>(this.Handle, "CParticleSystem", "m_nDataCP");

	// m_vecDataCPValue
	[SchemaMember("CParticleSystem", "m_vecDataCPValue")]
	public Vector DataCPValue => Schema.GetDeclaredClass<Vector>(this.Handle, "CParticleSystem", "m_vecDataCPValue");

	// m_nTintCP
	[SchemaMember("CParticleSystem", "m_nTintCP")]
	public ref Int32 TintCP => ref Schema.GetRef<Int32>(this.Handle, "CParticleSystem", "m_nTintCP");

	// m_clrTint
	[SchemaMember("CParticleSystem", "m_clrTint")]
	public Color Tint
	{
		get { return Schema.GetCustomMarshalledType<Color>(this.Handle, "CParticleSystem", "m_clrTint"); }
		set { Schema.SetCustomMarshalledType<Color>(this.Handle, "CParticleSystem", "m_clrTint", value); }
	}

}
