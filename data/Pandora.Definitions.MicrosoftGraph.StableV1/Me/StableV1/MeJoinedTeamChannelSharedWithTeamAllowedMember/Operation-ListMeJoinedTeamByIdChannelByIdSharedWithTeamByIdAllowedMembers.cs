// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Me.StableV1.MeJoinedTeamChannelSharedWithTeamAllowedMember;

internal class ListMeJoinedTeamByIdChannelByIdSharedWithTeamByIdAllowedMembersOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";
    public override ResourceID? ResourceId() => new MeJoinedTeamIdChannelIdSharedWithTeamId();
    public override Type NestedItemType() => typeof(ConversationMemberCollectionResponseModel);
    public override string? UriSuffix() => "/allowedMembers";
}
