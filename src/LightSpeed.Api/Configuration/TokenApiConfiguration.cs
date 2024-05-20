﻿using System.Diagnostics.CodeAnalysis;
using LightSpeed.Api.Configuration.Interfaces;

namespace LightSpeed.Api.Configuration;

/// <summary>
/// Used for authenticating with LightSpeed API with a personal token.
/// </summary>
public class TokenApiConfiguration : ILightSpeedApiConfiguration
{
    public required string ApiToken { get; init; }
    public required string StoreDomain { get; init; }
    [SetsRequiredMembers]
    public TokenApiConfiguration(string storeDomain, string apiToken)
    {
        StoreDomain = storeDomain;
        ApiToken = apiToken;
    }
}