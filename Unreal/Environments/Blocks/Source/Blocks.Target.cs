// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class BlocksTarget : TargetRules
{
	public BlocksTarget(TargetInfo Target) : base(Target)
	{
        	// If having trouble building with XCode version>13.3, uncomment following two lines:
        	// bOverrideBuildEnvironment = true;
        	// AdditionalCompilerArguments = "-Wno-unused-but-set-variable";

		Type = TargetType.Game;
		ExtraModuleNames.AddRange(new string[] { "Blocks" });

		//bUseUnityBuild = false;
		if (Target.Platform == UnrealTargetPlatform.Linux)
			bUsePCHFiles = false;
	}
}
