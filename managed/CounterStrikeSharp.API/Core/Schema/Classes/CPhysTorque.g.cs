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

public partial class CPhysTorque : CPhysForce
{
    public CPhysTorque (IntPtr pointer) : base(pointer) {}

	// m_axis
	[SchemaMember("CPhysTorque", "m_axis")]
	public Vector Axis => Schema.GetDeclaredClass<Vector>(this.Handle, "CPhysTorque", "m_axis");

}
