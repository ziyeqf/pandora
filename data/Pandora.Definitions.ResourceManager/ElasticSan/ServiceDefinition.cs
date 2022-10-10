using Pandora.Definitions.Interfaces;
using System.Collections.Generic;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ElasticSan;

public partial class Service : ServiceDefinition
{
    public string Name => "ElasticSan";
    public string? ResourceProvider => "Microsoft.ElasticSan";
    public string? TerraformPackageName => "elasticsan";

    public IEnumerable<TerraformResourceDefinition> TerraformResources => new List<TerraformResourceDefinition>
    {
        new Terraform.ElasticSanResource(),
    };
}
