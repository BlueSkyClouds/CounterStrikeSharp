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

public partial class CPhysThruster : CPhysForce
{
    public CPhysThruster (IntPtr pointer) : base(pointer) {}

	// m_localOrigin
	[SchemaMember("CPhysThruster", "m_localOrigin")]
	public Vector LocalOrigin => Schema.GetDeclaredClass<Vector>(this.Handle, "CPhysThruster", "m_localOrigin");

}
