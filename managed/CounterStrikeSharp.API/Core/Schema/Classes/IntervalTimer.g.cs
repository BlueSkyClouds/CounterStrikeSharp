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

public partial class IntervalTimer : NativeObject
{
    public IntervalTimer (IntPtr pointer) : base(pointer) {}

	// m_timestamp
	[SchemaMember("IntervalTimer", "m_timestamp")]
	public ref float Timestamp => ref Schema.GetRef<float>(this.Handle, "IntervalTimer", "m_timestamp");

	// m_nWorldGroupId
	[SchemaMember("IntervalTimer", "m_nWorldGroupId")]
	public WorldGroupId_t WorldGroupId => Schema.GetDeclaredClass<WorldGroupId_t>(this.Handle, "IntervalTimer", "m_nWorldGroupId");

}
