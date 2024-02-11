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

public partial class CPhysBox : CBreakable
{
    public CPhysBox (IntPtr pointer) : base(pointer) {}

	// m_damageType
	[SchemaMember("CPhysBox", "m_damageType")]
	public ref Int32 DamageType => ref Schema.GetRef<Int32>(this.Handle, "CPhysBox", "m_damageType");

	// m_massScale
	[SchemaMember("CPhysBox", "m_massScale")]
	public ref float MassScale => ref Schema.GetRef<float>(this.Handle, "CPhysBox", "m_massScale");

	// m_damageToEnableMotion
	[SchemaMember("CPhysBox", "m_damageToEnableMotion")]
	public ref Int32 DamageToEnableMotion => ref Schema.GetRef<Int32>(this.Handle, "CPhysBox", "m_damageToEnableMotion");

	// m_flForceToEnableMotion
	[SchemaMember("CPhysBox", "m_flForceToEnableMotion")]
	public ref float ForceToEnableMotion => ref Schema.GetRef<float>(this.Handle, "CPhysBox", "m_flForceToEnableMotion");

	// m_angPreferredCarryAngles
	[SchemaMember("CPhysBox", "m_angPreferredCarryAngles")]
	public QAngle PreferredCarryAngles => Schema.GetDeclaredClass<QAngle>(this.Handle, "CPhysBox", "m_angPreferredCarryAngles");

	// m_bNotSolidToWorld
	[SchemaMember("CPhysBox", "m_bNotSolidToWorld")]
	public ref bool NotSolidToWorld => ref Schema.GetRef<bool>(this.Handle, "CPhysBox", "m_bNotSolidToWorld");

	// m_bEnableUseOutput
	[SchemaMember("CPhysBox", "m_bEnableUseOutput")]
	public ref bool EnableUseOutput => ref Schema.GetRef<bool>(this.Handle, "CPhysBox", "m_bEnableUseOutput");

	// m_iExploitableByPlayer
	[SchemaMember("CPhysBox", "m_iExploitableByPlayer")]
	public ref Int32 ExploitableByPlayer => ref Schema.GetRef<Int32>(this.Handle, "CPhysBox", "m_iExploitableByPlayer");

	// m_flTouchOutputPerEntityDelay
	[SchemaMember("CPhysBox", "m_flTouchOutputPerEntityDelay")]
	public ref float TouchOutputPerEntityDelay => ref Schema.GetRef<float>(this.Handle, "CPhysBox", "m_flTouchOutputPerEntityDelay");

	// m_OnDamaged
	[SchemaMember("CPhysBox", "m_OnDamaged")]
	public CEntityIOOutput OnDamaged => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPhysBox", "m_OnDamaged");

	// m_OnAwakened
	[SchemaMember("CPhysBox", "m_OnAwakened")]
	public CEntityIOOutput OnAwakened => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPhysBox", "m_OnAwakened");

	// m_OnMotionEnabled
	[SchemaMember("CPhysBox", "m_OnMotionEnabled")]
	public CEntityIOOutput OnMotionEnabled => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPhysBox", "m_OnMotionEnabled");

	// m_OnPlayerUse
	[SchemaMember("CPhysBox", "m_OnPlayerUse")]
	public CEntityIOOutput OnPlayerUse => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPhysBox", "m_OnPlayerUse");

	// m_OnStartTouch
	[SchemaMember("CPhysBox", "m_OnStartTouch")]
	public CEntityIOOutput OnStartTouch => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPhysBox", "m_OnStartTouch");

	// m_hCarryingPlayer
	[SchemaMember("CPhysBox", "m_hCarryingPlayer")]
	public CHandle<CBasePlayerPawn> CarryingPlayer => Schema.GetDeclaredClass<CHandle<CBasePlayerPawn>>(this.Handle, "CPhysBox", "m_hCarryingPlayer");

}
