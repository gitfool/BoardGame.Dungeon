#load nuget:?package=Cake.Dungeon&prerelease

Build.SetParameters
(
    title: "BoardGame.Dungeon",

    defaultLog: true,

    runBuildSolutions: true,
    runDockerBuild: true,
    runUnitTests: true,
    runTestCoverageReports: true,
    runPublishToDocker: true,

    sourceDirectory: Build.Directories.Root,

    unitTestProjectPatterns: new[] { "Tests/*.csproj" },
    unitTestLoggers: new[] { "console;verbosity=detailed", "junit" },

    buildEmbedAllSources: true,
    dockerBuildCache: true,
    dockerBuildLoad: true,
    dockerBuildPull: true,
    dockerPushLatest: true,
    dockerPushSkipDuplicate: true,

    dockerImages: new[] { new DockerImage { Repository = "dockfool/boardgame-dungeon", Context = "Cli" } }
);

Build.Run();
