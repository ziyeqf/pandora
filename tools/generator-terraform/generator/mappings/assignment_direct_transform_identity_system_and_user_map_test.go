package mappings

import (
	"fmt"
	"testing"

	"github.com/hashicorp/pandora/tools/sdk/resourcemanager"
	"github.com/hashicorp/pandora/tools/sdk/testhelpers"
)

func TestDirectAssignment_CreateOrUpdate_Identity_SystemAndUserAssignedMap_RequiredToRequired(t *testing.T) {
	// mapping a Schema Model Field (Required) to an SDK Field (Required) for SystemAndUserAssignedIdentity

	testData := []struct {
		schemaModelFieldType resourcemanager.TerraformSchemaFieldType
		sdkFieldType         resourcemanager.ApiObjectDefinitionType
		expected             string
	}{
		{
			schemaModelFieldType: resourcemanager.TerraformSchemaFieldTypeIdentitySystemAndUserAssigned,
			sdkFieldType:         resourcemanager.SystemAndUserAssignedIdentityMapApiObjectDefinitionType,
			expected: fmt.Sprintf(`
   identity, err := identity.ExpandSystemAndUserAssignedMapFromModel(input.Identity)
   if err != nil {
      return fmt.Errorf("expanding SystemAndUserAssigned Identity: %%+v", err)
   }
   output.Identity = identity
`),
		},
	}
	for i, v := range testData {
		t.Logf("Test %d - mapping %q to %q", i, string(v.schemaModelFieldType), string(v.sdkFieldType))
		mapping := resourcemanager.FieldMappingDefinition{
			Type: resourcemanager.DirectAssignmentMappingDefinitionType,
			DirectAssignment: &resourcemanager.FieldMappingDirectAssignmentDefinition{
				SchemaModelName: "FromModel",
				SchemaFieldPath: "Identity",
				SdkFieldPath:    "Identity",
				SdkModelName:    "ToModel",
			},
		}
		schemaModel := resourcemanager.TerraformSchemaModelDefinition{
			Fields: map[string]resourcemanager.TerraformSchemaFieldDefinition{
				"Identity": {
					ObjectDefinition: resourcemanager.TerraformSchemaFieldObjectDefinition{
						Type: v.schemaModelFieldType,
					},
					HclName:  "identity",
					Required: true,
				},
			},
		}
		sdkModel := resourcemanager.ModelDetails{
			Fields: map[string]resourcemanager.FieldDetails{
				"Identity": {
					JsonName: "identity",
					ObjectDefinition: resourcemanager.ApiObjectDefinition{
						Type: v.sdkFieldType,
					},
					Required: true,
				},
			},
		}
		actual, err := directAssignmentLine{}.assignmentForCreateUpdateMapping(mapping, schemaModel, sdkModel, nil, "sdkresource")
		if err != nil {
			t.Fatalf("retrieving create/update assignment mapping: %+v", err)
		}
		if actual == nil {
			t.Fatalf("retrieving create/update assignment mapping: `actual` was nil")
		}
		testhelpers.AssertTemplatedCodeMatches(t, v.expected, *actual)
	}
}

func TestDirectAssignment_CreateOrUpdate_Identity_SystemAndUserAssignedMap_RequiredToOptional(t *testing.T) {
	// mapping a Schema Model Field (Required) to an SDK Field (Optional) for SystemAndUserAssignedIdentity

	testData := []struct {
		schemaModelFieldType resourcemanager.TerraformSchemaFieldType
		sdkFieldType         resourcemanager.ApiObjectDefinitionType
		expected             string
	}{
		{
			schemaModelFieldType: resourcemanager.TerraformSchemaFieldTypeIdentitySystemAndUserAssigned,
			sdkFieldType:         resourcemanager.SystemAndUserAssignedIdentityMapApiObjectDefinitionType,
			expected: fmt.Sprintf(`
   identity, err := identity.ExpandSystemAndUserAssignedMapFromModel(input.Identity)
   if err != nil {
      return fmt.Errorf("expanding SystemAndUserAssigned Identity: %%+v", err)
   }
   output.Identity = identity
`),
		},
	}
	for i, v := range testData {
		t.Logf("Test %d - mapping %q to %q", i, string(v.schemaModelFieldType), string(v.sdkFieldType))
		mapping := resourcemanager.FieldMappingDefinition{
			Type: resourcemanager.DirectAssignmentMappingDefinitionType,
			DirectAssignment: &resourcemanager.FieldMappingDirectAssignmentDefinition{
				SchemaModelName: "FromModel",
				SchemaFieldPath: "Identity",
				SdkFieldPath:    "Identity",
				SdkModelName:    "ToModel",
			},
		}
		schemaModel := resourcemanager.TerraformSchemaModelDefinition{
			Fields: map[string]resourcemanager.TerraformSchemaFieldDefinition{
				"Identity": {
					ObjectDefinition: resourcemanager.TerraformSchemaFieldObjectDefinition{
						Type: v.schemaModelFieldType,
					},
					HclName:  "identity",
					Required: true,
				},
			},
		}
		sdkModel := resourcemanager.ModelDetails{
			Fields: map[string]resourcemanager.FieldDetails{
				"Identity": {
					JsonName: "identity",
					ObjectDefinition: resourcemanager.ApiObjectDefinition{
						Type: v.sdkFieldType,
					},
					Optional: true,
				},
			},
		}
		actual, err := directAssignmentLine{}.assignmentForCreateUpdateMapping(mapping, schemaModel, sdkModel, nil, "sdkresource")
		if err != nil {
			t.Fatalf("retrieving create/update assignment mapping: %+v", err)
		}
		if actual == nil {
			t.Fatalf("retrieving create/update assignment mapping: `actual` was nil")
		}
		testhelpers.AssertTemplatedCodeMatches(t, v.expected, *actual)
	}
}

func TestDirectAssignment_CreateOrUpdate_Identity_SystemAndUserAssignedMap_OptionalToRequired(t *testing.T) {
	// mapping a Schema Model Field (Optional) to an SDK Field (Required) for tags
	// this has to be mapped, so is a Schema error / we should raise an error

	testData := []struct {
		schemaModelFieldType resourcemanager.TerraformSchemaFieldType
		sdkFieldType         resourcemanager.ApiObjectDefinitionType
	}{
		{
			schemaModelFieldType: resourcemanager.TerraformSchemaFieldTypeIdentitySystemAndUserAssigned,
			sdkFieldType:         resourcemanager.SystemAndUserAssignedIdentityMapApiObjectDefinitionType,
		},
	}
	for i, v := range testData {
		t.Logf("Test %d - mapping %q to %q", i, string(v.schemaModelFieldType), string(v.sdkFieldType))
		mapping := resourcemanager.FieldMappingDefinition{
			Type: resourcemanager.DirectAssignmentMappingDefinitionType,
			DirectAssignment: &resourcemanager.FieldMappingDirectAssignmentDefinition{
				SchemaModelName: "FromModel",
				SchemaFieldPath: "Identity",
				SdkFieldPath:    "Identity",
				SdkModelName:    "ToModel",
			},
		}
		schemaModel := resourcemanager.TerraformSchemaModelDefinition{
			Fields: map[string]resourcemanager.TerraformSchemaFieldDefinition{
				"Identity": {
					ObjectDefinition: resourcemanager.TerraformSchemaFieldObjectDefinition{
						Type: v.schemaModelFieldType,
					},
					HclName:  "identity",
					Optional: true,
				},
			},
		}
		sdkModel := resourcemanager.ModelDetails{
			Fields: map[string]resourcemanager.FieldDetails{
				"Identity": {
					JsonName: "identity",
					ObjectDefinition: resourcemanager.ApiObjectDefinition{
						Type: v.sdkFieldType,
					},
					Required: true,
				},
			},
		}
		actual, err := directAssignmentLine{}.assignmentForCreateUpdateMapping(mapping, schemaModel, sdkModel, nil, "sdkresource")
		if err == nil {
			t.Fatalf("expected an error but didn't get one")
		}
		if actual != nil {
			t.Fatalf("expected an error and no result but got a result (%q) and no error", *actual)
		}
	}
}

func TestDirectAssignment_CreateOrUpdate_Identity_SystemAndUserAssignedMap_OptionalToOptional(t *testing.T) {
	// mapping a Schema Model Field (Optional) to an SDK Field (Optional) for SystemAndUserAssignedIdentity

	testData := []struct {
		schemaModelFieldType resourcemanager.TerraformSchemaFieldType
		sdkFieldType         resourcemanager.ApiObjectDefinitionType
		expected             string
	}{
		{
			schemaModelFieldType: resourcemanager.TerraformSchemaFieldTypeIdentitySystemAndUserAssigned,
			sdkFieldType:         resourcemanager.SystemAndUserAssignedIdentityMapApiObjectDefinitionType,
			expected: fmt.Sprintf(`
   identity, err := identity.ExpandSystemAndUserAssignedMapFromModel(input.Identity)
   if err != nil {
      return fmt.Errorf("expanding SystemAndUserAssigned Identity: %%+v", err)
   }
   output.Identity = identity
`),
		},
	}
	for i, v := range testData {
		t.Logf("Test %d - mapping %q to %q", i, string(v.schemaModelFieldType), string(v.sdkFieldType))
		mapping := resourcemanager.FieldMappingDefinition{
			Type: resourcemanager.DirectAssignmentMappingDefinitionType,
			DirectAssignment: &resourcemanager.FieldMappingDirectAssignmentDefinition{
				SchemaModelName: "FromModel",
				SchemaFieldPath: "Identity",
				SdkFieldPath:    "Identity",
				SdkModelName:    "ToModel",
			},
		}
		schemaModel := resourcemanager.TerraformSchemaModelDefinition{
			Fields: map[string]resourcemanager.TerraformSchemaFieldDefinition{
				"Identity": {
					ObjectDefinition: resourcemanager.TerraformSchemaFieldObjectDefinition{
						Type: v.schemaModelFieldType,
					},
					HclName:  "identity",
					Optional: true,
				},
			},
		}
		sdkModel := resourcemanager.ModelDetails{
			Fields: map[string]resourcemanager.FieldDetails{
				"Identity": {
					JsonName: "identity",
					ObjectDefinition: resourcemanager.ApiObjectDefinition{
						Type: v.sdkFieldType,
					},
					Optional: true,
				},
			},
		}
		actual, err := directAssignmentLine{}.assignmentForCreateUpdateMapping(mapping, schemaModel, sdkModel, nil, "sdkresource")
		if err != nil {
			t.Fatalf("retrieving create/update assignment mapping: %+v", err)
		}
		if actual == nil {
			t.Fatalf("retrieving create/update assignment mapping: `actual` was nil")
		}
		testhelpers.AssertTemplatedCodeMatches(t, v.expected, *actual)
	}
}

func TestDirectAssignment_Read_Identity_SystemAndUserAssignedMap_RequiredToRequired(t *testing.T) {
	// when mapping a model to a model where both fields are required and matching SystemAndUserAssignedIdentity
	testData := []struct {
		schemaModelFieldType resourcemanager.TerraformSchemaFieldType
		sdkFieldType         resourcemanager.ApiObjectDefinitionType
		expected             string
	}{
		{
			schemaModelFieldType: resourcemanager.TerraformSchemaFieldTypeIdentitySystemAndUserAssigned,
			sdkFieldType:         resourcemanager.SystemAndUserAssignedIdentityMapApiObjectDefinitionType,
			expected: fmt.Sprintf(`
	identity, err := identity.FlattenSystemAndUserAssignedMapToModel(input.Identity)
	if err != nil {
		return fmt.Errorf("flattening SystemAndUserAssigned Identity: %%+v", err)
	}
	output.Identity = identity
`),
		},
	}
	for i, v := range testData {
		t.Logf("Test %d - mapping %q to %q", i, string(v.schemaModelFieldType), string(v.sdkFieldType))
		mapping := resourcemanager.FieldMappingDefinition{
			Type: resourcemanager.DirectAssignmentMappingDefinitionType,
			DirectAssignment: &resourcemanager.FieldMappingDirectAssignmentDefinition{
				SchemaModelName: "FromModel",
				SchemaFieldPath: "Identity",
				SdkFieldPath:    "Identity",
				SdkModelName:    "ToModel",
			},
		}
		schemaModel := resourcemanager.TerraformSchemaModelDefinition{
			Fields: map[string]resourcemanager.TerraformSchemaFieldDefinition{
				"Identity": {
					ObjectDefinition: resourcemanager.TerraformSchemaFieldObjectDefinition{
						Type: v.schemaModelFieldType,
					},
					HclName:  "identity",
					Required: true,
				},
			},
		}
		sdkModel := resourcemanager.ModelDetails{
			Fields: map[string]resourcemanager.FieldDetails{
				"Identity": {
					JsonName: "identity",
					ObjectDefinition: resourcemanager.ApiObjectDefinition{
						Type: v.sdkFieldType,
					},
					Required: true,
				},
			},
		}
		actual, err := directAssignmentLine{}.assignmentForReadMapping(mapping, schemaModel, sdkModel, nil, "sdkresource")
		if err != nil {
			t.Fatalf("retrieving read assignment mapping: %+v", err)
		}
		if actual == nil {
			t.Fatalf("retrieving read assignment mapping: `actual` was nil")
		}
		testhelpers.AssertTemplatedCodeMatches(t, v.expected, *actual)
	}
}

func TestDirectAssignment_Read_Identity_SystemAndUserAssignedMap_RequiredToOptional(t *testing.T) {
	// when mapping a model to a model where the Schema field is Required but the SDK field is Optional
	// and matching SystemAndUserAssignedIdentity
	testData := []struct {
		schemaModelFieldType resourcemanager.TerraformSchemaFieldType
		sdkFieldType         resourcemanager.ApiObjectDefinitionType
		expected             string
	}{
		{
			schemaModelFieldType: resourcemanager.TerraformSchemaFieldTypeIdentitySystemAndUserAssigned,
			sdkFieldType:         resourcemanager.SystemAndUserAssignedIdentityMapApiObjectDefinitionType,
			expected: fmt.Sprintf(`
	identity, err := identity.FlattenSystemAndUserAssignedMapToModel(input.Identity)
	if err != nil {
		return fmt.Errorf("flattening SystemAndUserAssigned Identity: %%+v", err)
	}
	output.Identity = *identity
`),
		},
	}
	for i, v := range testData {
		t.Logf("Test %d - mapping %q to %q", i, string(v.schemaModelFieldType), string(v.sdkFieldType))
		mapping := resourcemanager.FieldMappingDefinition{
			Type: resourcemanager.DirectAssignmentMappingDefinitionType,
			DirectAssignment: &resourcemanager.FieldMappingDirectAssignmentDefinition{
				SchemaModelName: "FromModel",
				SchemaFieldPath: "Identity",
				SdkFieldPath:    "Identity",
				SdkModelName:    "ToModel",
			},
		}
		schemaModel := resourcemanager.TerraformSchemaModelDefinition{
			Fields: map[string]resourcemanager.TerraformSchemaFieldDefinition{
				"Identity": {
					ObjectDefinition: resourcemanager.TerraformSchemaFieldObjectDefinition{
						Type: v.schemaModelFieldType,
					},
					HclName:  "identity",
					Required: true,
				},
			},
		}
		sdkModel := resourcemanager.ModelDetails{
			Fields: map[string]resourcemanager.FieldDetails{
				"Identity": {
					JsonName: "identity",
					ObjectDefinition: resourcemanager.ApiObjectDefinition{
						Type: v.sdkFieldType,
					},
					Optional: true,
				},
			},
		}
		actual, err := directAssignmentLine{}.assignmentForReadMapping(mapping, schemaModel, sdkModel, nil, "sdkresource")
		if err != nil {
			t.Fatalf("retrieving read assignment mapping: %+v", err)
		}
		if actual == nil {
			t.Fatalf("retrieving read assignment mapping: `actual` was nil")
		}
		testhelpers.AssertTemplatedCodeMatches(t, v.expected, *actual)
	}
}

func TestDirectAssignment_Read_Identity_SystemAndUserAssignedMap_OptionalToRequired(t *testing.T) {
	// when mapping a model to a model where the Schema field is Optional but the SDK field is Required
	// this has to be mapped, so is a Schema error / we should raise an error

	testData := []struct {
		schemaModelFieldType resourcemanager.TerraformSchemaFieldType
		sdkFieldType         resourcemanager.ApiObjectDefinitionType
	}{
		{
			schemaModelFieldType: resourcemanager.TerraformSchemaFieldTypeIdentitySystemAndUserAssigned,
			sdkFieldType:         resourcemanager.SystemAndUserAssignedIdentityMapApiObjectDefinitionType,
		},
	}
	for i, v := range testData {
		t.Logf("Test %d - mapping %q to %q", i, string(v.schemaModelFieldType), string(v.sdkFieldType))
		mapping := resourcemanager.FieldMappingDefinition{
			Type: resourcemanager.DirectAssignmentMappingDefinitionType,
			DirectAssignment: &resourcemanager.FieldMappingDirectAssignmentDefinition{
				SchemaModelName: "FromModel",
				SchemaFieldPath: "Identity",
				SdkFieldPath:    "Identity",
				SdkModelName:    "ToModel",
			},
		}
		schemaModel := resourcemanager.TerraformSchemaModelDefinition{
			Fields: map[string]resourcemanager.TerraformSchemaFieldDefinition{
				"Identity": {
					ObjectDefinition: resourcemanager.TerraformSchemaFieldObjectDefinition{
						Type: v.schemaModelFieldType,
					},
					HclName:  "identity",
					Optional: true,
				},
			},
		}
		sdkModel := resourcemanager.ModelDetails{
			Fields: map[string]resourcemanager.FieldDetails{
				"Identity": {
					JsonName: "identity",
					ObjectDefinition: resourcemanager.ApiObjectDefinition{
						Type: v.sdkFieldType,
					},
					Required: true,
				},
			},
		}
		actual, err := directAssignmentLine{}.assignmentForReadMapping(mapping, schemaModel, sdkModel, nil, "sdkresource")
		if err == nil {
			t.Fatalf("expected an error but didn't get one")
		}
		if actual != nil {
			t.Fatalf("expected an error and no result but got a result (%q) and no error", *actual)
		}
	}
}

func TestDirectAssignment_Read_Identity_SystemAndUserAssignedMap_OptionalToOptional(t *testing.T) {
	// when mapping a model to a model where both fields are optional and matching SystemAndUserAssignedIdentity
	testData := []struct {
		schemaModelFieldType resourcemanager.TerraformSchemaFieldType
		sdkFieldType         resourcemanager.ApiObjectDefinitionType
		expected             string
	}{
		{
			schemaModelFieldType: resourcemanager.TerraformSchemaFieldTypeIdentitySystemAndUserAssigned,
			sdkFieldType:         resourcemanager.SystemAndUserAssignedIdentityMapApiObjectDefinitionType,
			expected: fmt.Sprintf(`
	identity, err := identity.FlattenSystemAndUserAssignedMapToModel(input.Identity)
	if err != nil {
		return fmt.Errorf("flattening SystemAndUserAssigned Identity: %%+v", err)
	}
	output.Identity = *identity
`),
		},
	}
	for i, v := range testData {
		t.Logf("Test %d - mapping %q to %q", i, string(v.schemaModelFieldType), string(v.sdkFieldType))
		mapping := resourcemanager.FieldMappingDefinition{
			Type: resourcemanager.DirectAssignmentMappingDefinitionType,
			DirectAssignment: &resourcemanager.FieldMappingDirectAssignmentDefinition{
				SchemaModelName: "FromModel",
				SchemaFieldPath: "Identity",
				SdkFieldPath:    "Identity",
				SdkModelName:    "ToModel",
			},
		}
		schemaModel := resourcemanager.TerraformSchemaModelDefinition{
			Fields: map[string]resourcemanager.TerraformSchemaFieldDefinition{
				"Identity": {
					ObjectDefinition: resourcemanager.TerraformSchemaFieldObjectDefinition{
						Type: v.schemaModelFieldType,
					},
					HclName:  "identity",
					Optional: true,
				},
			},
		}
		sdkModel := resourcemanager.ModelDetails{
			Fields: map[string]resourcemanager.FieldDetails{
				"Identity": {
					JsonName: "identity",
					ObjectDefinition: resourcemanager.ApiObjectDefinition{
						Type: v.sdkFieldType,
					},
					Optional: true,
				},
			},
		}
		actual, err := directAssignmentLine{}.assignmentForReadMapping(mapping, schemaModel, sdkModel, nil, "sdkresource")
		if err != nil {
			t.Fatalf("retrieving read assignment mapping: %+v", err)
		}
		if actual == nil {
			t.Fatalf("retrieving read assignment mapping: `actual` was nil")
		}
		testhelpers.AssertTemplatedCodeMatches(t, v.expected, *actual)
	}
}
