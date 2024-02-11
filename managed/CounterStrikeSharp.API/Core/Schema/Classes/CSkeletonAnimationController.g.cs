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

public partial class CSkeletonAnimationController : ISkeletonAnimationController
{
    public CSkeletonAnimationController (IntPtr pointer) : base(pointer) {}

	// m_pSkeletonInstance
	[SchemaMember("CSkeletonAnimationController", "m_pSkeletonInstance")]
	public CSkeletonInstance? SkeletonInstance => Schema.GetPointer<CSkeletonInstance>(this.Handle, "CSkeletonAnimationController", "m_pSkeletonInstance");

}
