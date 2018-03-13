// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class projet_test_unrealEditorTarget : TargetRules
{
	public projet_test_unrealEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "projet_test_unreal" } );
	}
}
