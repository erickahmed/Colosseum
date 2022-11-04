// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class BlocksEditorTarget : TargetRules
{
	public BlocksEditorTarget(TargetInfo Target) : base(Target)
	{
        // If having trouble building with XCode version>13.3, uncomment following two lines:
        // bOverrideBuildEnvironment = true;
        // AdditionalCompilerArguments = "-Wno-unused-but-set-variable";

		Type = TargetType.Editor;
		ExtraModuleNames.AddRange(new string[] { "Blocks" });
        DefaultBuildSettings = BuildSettingsVersion.V2;
        //bUseUnityBuild = false;
        //bUsePCHFiles = false;
    }
}
