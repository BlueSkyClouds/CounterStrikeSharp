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

public partial class CPropDoorRotatingBreakable : CPropDoorRotating
{
    public CPropDoorRotatingBreakable (IntPtr pointer) : base(pointer) {}

	// m_bBreakable
	[SchemaMember("CPropDoorRotatingBreakable", "m_bBreakable")]
	public ref bool Breakable => ref Schema.GetRef<bool>(this.Handle, "CPropDoorRotatingBreakable", "m_bBreakable");

	// m_isAbleToCloseAreaPortals
	[SchemaMember("CPropDoorRotatingBreakable", "m_isAbleToCloseAreaPortals")]
	public ref bool IsAbleToCloseAreaPortals => ref Schema.GetRef<bool>(this.Handle, "CPropDoorRotatingBreakable", "m_isAbleToCloseAreaPortals");

	// m_currentDamageState
	[SchemaMember("CPropDoorRotatingBreakable", "m_currentDamageState")]
	public ref Int32 CurrentDamageState => ref Schema.GetRef<Int32>(this.Handle, "CPropDoorRotatingBreakable", "m_currentDamageState");

	// m_damageStates
	[SchemaMember("CPropDoorRotatingBreakable", "m_damageStates")]
	public NetworkedVector<string> DamageStates => Schema.GetDeclaredClass<NetworkedVector<string>>(this.Handle, "CPropDoorRotatingBreakable", "m_damageStates");

}
