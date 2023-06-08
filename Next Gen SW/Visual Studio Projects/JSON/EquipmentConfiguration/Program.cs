// See https://aka.ms/new-console-template for more information
using EquipmentConfiguration;
using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;
using System;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

//string json = File.ReadAllText("Employee.json");
//var schemaFromFile = JsonSchema.FromSampleJson(json);

//JSON schema to C# classes
var schemaFromFile = JsonSchema.FromFileAsync("..\\..\\..\\equipment-config-schema.json");
var classGenerator = new CSharpGenerator(schemaFromFile.Result, new CSharpGeneratorSettings
{
    ClassStyle = CSharpClassStyle.Poco,
});
var codeFile = classGenerator.GenerateFile();
File.WriteAllText("..\\..\\..\\Model\\EquipmentConfig.cs", codeFile);

//C# classes to JSON schema
var schema = JsonSchema.FromType<Equipment>();
var schemaJson = schema.ToJson();
File.WriteAllText("Equipment.json",schemaJson);

// notice reference to 'equipment' in the schema
var schemaPos = JsonSchema.FromType<Positioner>();
var schemaJsonPos = schemaPos.ToJson();
File.WriteAllText("Positioner.json", schemaJsonPos);

