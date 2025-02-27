// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class ParticipantModel
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("info")]
    public ParticipantInfoModel? Info { get; set; }

    [JsonPropertyName("isIdentityAnonymized")]
    public bool? IsIdentityAnonymized { get; set; }

    [JsonPropertyName("isInLobby")]
    public bool? IsInLobby { get; set; }

    [JsonPropertyName("isMuted")]
    public bool? IsMuted { get; set; }

    [JsonPropertyName("mediaStreams")]
    public List<MediaStreamModel>? MediaStreams { get; set; }

    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("preferredDisplayName")]
    public string? PreferredDisplayName { get; set; }

    [JsonPropertyName("recordingInfo")]
    public RecordingInfoModel? RecordingInfo { get; set; }

    [JsonPropertyName("removedState")]
    public RemovedStateModel? RemovedState { get; set; }

    [JsonPropertyName("restrictedExperience")]
    public OnlineMeetingRestrictedModel? RestrictedExperience { get; set; }

    [JsonPropertyName("rosterSequenceNumber")]
    public int? RosterSequenceNumber { get; set; }
}
