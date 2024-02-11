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

public partial class CAttributeList : NativeObject
{
    public CAttributeList (IntPtr pointer) : base(pointer) {}

	// m_Attributes
	[SchemaMember("CAttributeList", "m_Attributes")]
	public NetworkedVector<CEconItemAttribute> Attributes => Schema.GetDeclaredClass<NetworkedVector<CEconItemAttribute>>(this.Handle, "CAttributeList", "m_Attributes");

	// m_pManager
	[SchemaMember("CAttributeList", "m_pManager")]
	public CAttributeManager? Manager => Schema.GetPointer<CAttributeManager>(this.Handle, "CAttributeList", "m_pManager");

}
