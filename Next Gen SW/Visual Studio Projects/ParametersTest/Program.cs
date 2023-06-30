// See https://aka.ms/new-console-template for more information
using ETS.Parameters;
using Newtonsoft.Json;

var parameters = new Parameters();

parameters.Name = "Positioner";
parameters.Description = "Positoner Template";
parameters.Children = new List<Parameters>();

var commonParameters = new Parameters();
commonParameters.Name = "Common Parameters";
commonParameters.Description = "Parameters Common to all Positioners";
parameters.Children.Add(commonParameters);

var etsPositionerParameters = new Parameters();
etsPositionerParameters.Name = "ETS-Lindgren 3-Axis Positioner";
etsPositionerParameters.Description = "Parameters Specific to ETS-Lindgren 3-Axis Positioners";
parameters.Children.Add(etsPositionerParameters);

commonParameters.Properties = new List<PropertyElement>();

var axisName = new PropertyElement();
axisName.Name = "AxisName";
axisName.Description = "The name of the axis, eg: Phi/Theta";
axisName.DisplayName = "Axis Name";
axisName.DisplayOrder = 0;
axisName.ValidationRules = new List<ValidationRuleElement>
{
    new ValidationRuleElement() { Name = "NotNullOrEmpty" }
};
commonParameters.Properties.Add(axisName);

var visaConnectString = new PropertyElement();
visaConnectString.Name = "VisaConnectString";
visaConnectString.Description = "The instrument connection string";
visaConnectString.DisplayName = "Visa ConnectString";
visaConnectString.DisplayOrder = 1;
visaConnectString.ValidationRules = new List<ValidationRuleElement>
{
    new ValidationRuleElement() { Name = "NotNullOrEmpty" }
};
commonParameters.Properties.Add(visaConnectString);

var upperLimit = new PropertyElement();
upperLimit.Name = "UpperLimit";
upperLimit.Description = "The upper limit in degrees or cm";
upperLimit.DisplayName = "Upper Limit";
upperLimit.DisplayOrder = 2;
upperLimit.ValidationRules = new List<ValidationRuleElement>{ new ValidationRuleElement() { Name = "NotNullOrEmpty" }};
upperLimit.Range = new ETS.Parameters.Range() { StartValue = "0", StopValue = "999", StepValue="0.1"};
upperLimit.DisplayUnits = "°/cm";
upperLimit.Format = "F1";
upperLimit.Value = new ChoiceList();
upperLimit.Value.DoubleValue = 999;
commonParameters.Properties.Add(upperLimit);

var lowerLimit = new PropertyElement();
lowerLimit.Name = "lowerLimit";
lowerLimit.Description = "The lower limit in degrees or cm";
lowerLimit.DisplayName = "Lower Limit";
lowerLimit.DisplayOrder = 3;
lowerLimit.ValidationRules = new List<ValidationRuleElement> { new ValidationRuleElement() { Name = "NotNullOrEmpty" }};
lowerLimit.Range = new ETS.Parameters.Range() { StartValue = "0", StopValue = "-999", StepValue = "0.1" };
lowerLimit.DisplayUnits = "°/cm";
lowerLimit.Format = "F1";
lowerLimit.Value = new ChoiceList();
lowerLimit.Value.DoubleValue = -999;

commonParameters.Properties.Add(lowerLimit);

string output = JsonConvert.SerializeObject(parameters, Formatting.Indented);

var obj = JsonConvert.DeserializeObject<Parameters>(output);


Console.WriteLine(output);

