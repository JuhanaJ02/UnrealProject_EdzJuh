// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class JUHANAEETU : ModuleRules
{
	public JUHANAEETU(ReadOnlyTargetRules Target) : base(Target)
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
			"JUHANAEETU",
			"JUHANAEETU/Variant_Platforming",
			"JUHANAEETU/Variant_Platforming/Animation",
			"JUHANAEETU/Variant_Combat",
			"JUHANAEETU/Variant_Combat/AI",
			"JUHANAEETU/Variant_Combat/Animation",
			"JUHANAEETU/Variant_Combat/Gameplay",
			"JUHANAEETU/Variant_Combat/Interfaces",
			"JUHANAEETU/Variant_Combat/UI",
			"JUHANAEETU/Variant_SideScrolling",
			"JUHANAEETU/Variant_SideScrolling/AI",
			"JUHANAEETU/Variant_SideScrolling/Gameplay",
			"JUHANAEETU/Variant_SideScrolling/Interfaces",
			"JUHANAEETU/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
