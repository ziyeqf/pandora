using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DNS.v2018_05_01.RecordSets;

internal class Definition : ResourceDefinition
{
    public string Name => "RecordSets";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListAllByDnsZoneOperation(),
        new ListByDnsZoneOperation(),
        new ListByTypeOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(RecordTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ARecordModel),
        typeof(AaaaRecordModel),
        typeof(CaaRecordModel),
        typeof(CnameRecordModel),
        typeof(MxRecordModel),
        typeof(NsRecordModel),
        typeof(PtrRecordModel),
        typeof(RecordSetModel),
        typeof(RecordSetPropertiesModel),
        typeof(SoaRecordModel),
        typeof(SrvRecordModel),
        typeof(SubResourceModel),
        typeof(TxtRecordModel),
    };
}
