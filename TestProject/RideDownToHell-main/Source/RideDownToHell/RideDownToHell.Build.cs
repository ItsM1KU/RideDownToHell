// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class RideDownToHell : ModuleRules
{
	public RideDownToHell(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"RideDownToHell",
			"RideDownToHell/Variant_Horror",
			"RideDownToHell/Variant_Horror/UI",
			"RideDownToHell/Variant_Shooter",
			"RideDownToHell/Variant_Shooter/AI",
			"RideDownToHell/Variant_Shooter/UI",
			"RideDownToHell/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
