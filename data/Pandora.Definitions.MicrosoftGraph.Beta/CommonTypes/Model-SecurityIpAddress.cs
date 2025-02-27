// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class SecurityIpAddressModel
{
    [JsonPropertyName("autonomousSystem")]
    public SecurityAutonomousSystemModel? AutonomousSystem { get; set; }

    [JsonPropertyName("childHostPairs")]
    public List<SecurityHostPairModel>? ChildHostPairs { get; set; }

    [JsonPropertyName("components")]
    public List<SecurityHostComponentModel>? Components { get; set; }

    [JsonPropertyName("cookies")]
    public List<SecurityHostCookieModel>? Cookies { get; set; }

    [JsonPropertyName("countryOrRegion")]
    public string? CountryOrRegion { get; set; }

    [JsonPropertyName("firstSeenDateTime")]
    public DateTime? FirstSeenDateTime { get; set; }

    [JsonPropertyName("hostPairs")]
    public List<SecurityHostPairModel>? HostPairs { get; set; }

    [JsonPropertyName("hostingProvider")]
    public string? HostingProvider { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("lastSeenDateTime")]
    public DateTime? LastSeenDateTime { get; set; }

    [JsonPropertyName("netblock")]
    public string? Netblock { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("parentHostPairs")]
    public List<SecurityHostPairModel>? ParentHostPairs { get; set; }

    [JsonPropertyName("passiveDns")]
    public List<SecurityPassiveDnsRecordModel>? PassiveDns { get; set; }

    [JsonPropertyName("passiveDnsReverse")]
    public List<SecurityPassiveDnsRecordModel>? PassiveDnsReverse { get; set; }

    [JsonPropertyName("ports")]
    public List<SecurityHostPortModel>? Ports { get; set; }

    [JsonPropertyName("reputation")]
    public SecurityHostReputationModel? Reputation { get; set; }

    [JsonPropertyName("sslCertificates")]
    public List<SecurityHostSslCertificateModel>? SslCertificates { get; set; }

    [JsonPropertyName("subdomains")]
    public List<SecuritySubdomainModel>? Subdomains { get; set; }

    [JsonPropertyName("trackers")]
    public List<SecurityHostTrackerModel>? Trackers { get; set; }

    [JsonPropertyName("whois")]
    public SecurityWhoisRecordModel? Whois { get; set; }
}
