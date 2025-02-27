using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Web.v2023_01_01.CertificateOrdersDiagnostics;

internal class GetAppServiceCertificateOrderDetectorResponseOperation : Pandora.Definitions.Operations.GetOperation
{
    public override ResourceID? ResourceId() => new DetectorId();

    public override Type? ResponseObject() => typeof(DetectorResponseModel);

    public override Type? OptionsObject() => typeof(GetAppServiceCertificateOrderDetectorResponseOperation.GetAppServiceCertificateOrderDetectorResponseOptions);

    internal class GetAppServiceCertificateOrderDetectorResponseOptions
    {
        [QueryStringName("endTime")]
        [Optional]
        public string EndTime { get; set; }

        [QueryStringName("startTime")]
        [Optional]
        public string StartTime { get; set; }

        [QueryStringName("timeGrain")]
        [Optional]
        public string TimeGrain { get; set; }
    }
}
