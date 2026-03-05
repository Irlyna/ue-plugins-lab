// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PluginsLab : ModuleRules
{
	public PluginsLab(ReadOnlyTargetRules Target) : base(Target)
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
			"PluginsLab",
			"PluginsLab/Variant_Platforming",
			"PluginsLab/Variant_Platforming/Animation",
			"PluginsLab/Variant_Combat",
			"PluginsLab/Variant_Combat/AI",
			"PluginsLab/Variant_Combat/Animation",
			"PluginsLab/Variant_Combat/Gameplay",
			"PluginsLab/Variant_Combat/Interfaces",
			"PluginsLab/Variant_Combat/UI",
			"PluginsLab/Variant_SideScrolling",
			"PluginsLab/Variant_SideScrolling/AI",
			"PluginsLab/Variant_SideScrolling/Gameplay",
			"PluginsLab/Variant_SideScrolling/Interfaces",
			"PluginsLab/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
