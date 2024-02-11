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

public partial class CPhysImpact : CPointEntity
{
    public CPhysImpact (IntPtr pointer) : base(pointer) {}

	// m_damage
	[SchemaMember("CPhysImpact", "m_damage")]
	public ref float Damage => ref Schema.GetRef<float>(this.Handle, "CPhysImpact", "m_damage");

	// m_distance
	[SchemaMember("CPhysImpact", "m_distance")]
	public ref float Distance => ref Schema.GetRef<float>(this.Handle, "CPhysImpact", "m_distance");

	// m_directionEntityName
	[SchemaMember("CPhysImpact", "m_directionEntityName")]
	public string DirectionEntityName
	{
		get { return Schema.GetUtf8String(this.Handle, "CPhysImpact", "m_directionEntityName"); }
		set { Schema.SetString(this.Handle, "CPhysImpact", "m_directionEntityName", value); }
	}

}
