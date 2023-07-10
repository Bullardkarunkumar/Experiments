// See https://aka.ms/new-console-template for more information
using ETS.Parameters;
using Newtonsoft.Json;
using ValueType = ETS.Parameters.ValueType;

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

etsPositionerParameters.Properties = new List<PropertyElement>();

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
upperLimit.Value = new ValueType();
upperLimit.Value.DoubleValue = 999;
commonParameters.Properties.Add(upperLimit);

var lowerLimit = new PropertyElement();
lowerLimit.Name = "LowerLimit";
lowerLimit.Description = "The lower limit in degrees or cm";
lowerLimit.DisplayName = "Lower Limit";
lowerLimit.DisplayOrder = 3;
lowerLimit.ValidationRules = new List<ValidationRuleElement> { new ValidationRuleElement() { Name = "NotNullOrEmpty" }};
lowerLimit.Range = new ETS.Parameters.Range() { StartValue = "0", StopValue = "-999", StepValue = "0.1" };
lowerLimit.DisplayUnits = "°/cm";
lowerLimit.Format = "F1";
lowerLimit.Value = new ValueType();
lowerLimit.Value.DoubleValue = -999;
commonParameters.Properties.Add(lowerLimit);

var speedSetting1 = new PropertyElement();
speedSetting1.Name = "SpeedSetting1";
speedSetting1.Description = "The speed setting in percent";
speedSetting1.DisplayName = "Speed Setting 1";
speedSetting1.DisplayOrder = 4;
speedSetting1.ValidationRules = new List<ValidationRuleElement> { new ValidationRuleElement() { Name = "NotNullOrEmpty" } };
speedSetting1.Range = new ETS.Parameters.Range() { StartValue = "0", StopValue = "100", StepValue = "0.1" };
speedSetting1.DisplayUnits = "%";
speedSetting1.Format = "F1";
speedSetting1.Value = new ValueType();
speedSetting1.Value.DoubleValue = 12.5;
commonParameters.Properties.Add(speedSetting1);

var speedSetting2 = new PropertyElement();
speedSetting2.Name = "SpeedSetting2";
speedSetting2.Description = "The speed setting in percent";
speedSetting2.DisplayName = "Speed Setting 2";
speedSetting2.DisplayOrder = 5;
speedSetting2.ValidationRules = new List<ValidationRuleElement> { new ValidationRuleElement() { Name = "NotNullOrEmpty" } };
speedSetting2.Range = new ETS.Parameters.Range() { StartValue = "0", StopValue = "100", StepValue = "0.1" };
speedSetting2.DisplayUnits = "%";
speedSetting2.Format = "F1";
speedSetting2.Value = new ValueType();
speedSetting2.Value.DoubleValue = 25;
commonParameters.Properties.Add(speedSetting2);

var speedSetting3 = new PropertyElement();
speedSetting3.Name = "SpeedSetting3";
speedSetting3.Description = "The speed setting in percent";
speedSetting3.DisplayName = "Speed Setting 3";
speedSetting3.DisplayOrder = 6;
speedSetting3.ValidationRules = new List<ValidationRuleElement> { new ValidationRuleElement() { Name = "NotNullOrEmpty" } };
speedSetting3.Range = new ETS.Parameters.Range() { StartValue = "0", StopValue = "100", StepValue = "0.1" };
speedSetting3.DisplayUnits = "%";
speedSetting3.Format = "F1";
speedSetting3.Value = new ValueType();
speedSetting3.Value.DoubleValue = 37.5;
commonParameters.Properties.Add(speedSetting3);

var speedSetting4 = new PropertyElement();
speedSetting4.Name = "SpeedSetting4";
speedSetting4.Description = "The speed setting in percent";
speedSetting4.DisplayName = "Speed Setting 4";
speedSetting4.DisplayOrder = 7;
speedSetting4.ValidationRules = new List<ValidationRuleElement> { new ValidationRuleElement() { Name = "NotNullOrEmpty" } };
speedSetting4.Range = new ETS.Parameters.Range() { StartValue = "0", StopValue = "100", StepValue = "0.1" };
speedSetting4.DisplayUnits = "%";
speedSetting4.Format = "F1";
speedSetting4.Value = new ValueType();
speedSetting4.Value.DoubleValue = 50;
commonParameters.Properties.Add(speedSetting4);

var speedSetting5 = new PropertyElement();
speedSetting5.Name = "SpeedSetting5";
speedSetting5.Description = "The speed setting in percent";
speedSetting5.DisplayName = "Speed Setting 5";
speedSetting5.DisplayOrder = 8;
speedSetting5.ValidationRules = new List<ValidationRuleElement> { new ValidationRuleElement() { Name = "NotNullOrEmpty" } };
speedSetting5.Range = new ETS.Parameters.Range() { StartValue = "0", StopValue = "100", StepValue = "0.1" };
speedSetting5.DisplayUnits = "%";
speedSetting5.Format = "F1";
speedSetting5.Value = new ValueType();
speedSetting5.Value.DoubleValue = 62.5;
commonParameters.Properties.Add(speedSetting5);

var speedSetting6 = new PropertyElement();
speedSetting6.Name = "SpeedSetting6";
speedSetting6.Description = "The speed setting in percent";
speedSetting6.DisplayName = "Speed Setting 6";
speedSetting6.DisplayOrder = 9;
speedSetting6.ValidationRules = new List<ValidationRuleElement> { new ValidationRuleElement() { Name = "NotNullOrEmpty" } };
speedSetting6.Range = new ETS.Parameters.Range() { StartValue = "0", StopValue = "100", StepValue = "0.1" };
speedSetting6.DisplayUnits = "%";
speedSetting6.Format = "F1";
speedSetting6.Value = new ValueType();
speedSetting6.Value.DoubleValue = 75;
commonParameters.Properties.Add(speedSetting6);

var speedSetting7 = new PropertyElement();
speedSetting7.Name = "SpeedSetting7";
speedSetting7.Description = "The speed setting in percent";
speedSetting7.DisplayName = "Speed Setting 7";
speedSetting7.DisplayOrder = 10;
speedSetting7.ValidationRules = new List<ValidationRuleElement> { new ValidationRuleElement() { Name = "NotNullOrEmpty" } };
speedSetting7.Range = new ETS.Parameters.Range() { StartValue = "0", StopValue = "100", StepValue = "0.1" };
speedSetting7.DisplayUnits = "%";
speedSetting7.Format = "F1";
speedSetting7.Value = new ValueType();
speedSetting7.Value.DoubleValue = 87.5;
commonParameters.Properties.Add(speedSetting7);

var speedSetting8 = new PropertyElement();
speedSetting8.Name = "SpeedSetting8";
speedSetting8.Description = "The speed setting in percent";
speedSetting8.DisplayName = "Speed Setting 8";
speedSetting8.DisplayOrder = 11;
speedSetting8.ValidationRules = new List<ValidationRuleElement> { new ValidationRuleElement() { Name = "NotNullOrEmpty" } };
speedSetting8.Range = new ETS.Parameters.Range() { StartValue = "0", StopValue = "100", StepValue = "0.1" };
speedSetting8.DisplayUnits = "%";
speedSetting8.Format = "F1";
speedSetting8.Value = new ValueType();
speedSetting8.Value.DoubleValue = 100;
commonParameters.Properties.Add(speedSetting8);

var axisType = new PropertyElement();
axisType.Name = "AxisType";
axisType.Description = "Rotational/Linear";
axisType.DisplayName = "Axis Type";
axisType.DisplayOrder = 12;
axisType.ValidationRules = new List<ValidationRuleElement> { new ValidationRuleElement() { Name = "NotNullOrEmpty" } };
axisType.ChoiceList = new List<ValueType>
{
    new ValueType() { StringValue = "Rotational" },
    new ValueType() { StringValue = "Linear" }
};
axisType.Value = new ValueType();
axisType.Value.StringValue = "Rotational";
commonParameters.Properties.Add(axisType);

var axisRotation = new PropertyElement();
axisRotation.Name = "AxisRotation";
axisRotation.Description = "Non-Continuous/Continuous";
axisRotation.DisplayName = "Axis Rotation";
axisRotation.DisplayOrder = 13;
axisRotation.ValidationRules = new List<ValidationRuleElement> { new ValidationRuleElement() { Name = "NotNullOrEmpty" } };
axisRotation.ChoiceList = new List<ValueType>
{
    new ValueType() { StringValue = "NonContinuous" },
    new ValueType() { StringValue = "Continuous" }
};
axisRotation.Value = new ValueType();
axisRotation.Value.StringValue = "Continuous";
commonParameters.Properties.Add(axisRotation);

var slot = new PropertyElement();
slot.Name = "Slot";
slot.Description = "EMCenter Slot";
slot.DisplayName = "Slot";
slot.DisplayOrder = 1;
slot.ValidationRules = new List<ValidationRuleElement> { new ValidationRuleElement() { Name = "NotNullOrEmpty" } };
slot.ChoiceList = new List<ValueType>
{
    new ValueType() { StringValue = "A" },
    new ValueType() { StringValue = "B" },
    new ValueType() { StringValue = "C" }
};
slot.Value = new ValueType();
slot.Value.StringValue = "A";
etsPositionerParameters.Properties.Add(slot);

var channel = new PropertyElement();
channel.Name = "Channel";
channel.Description = "EMCenter Channel";
channel.DisplayName = "Channel";
channel.DisplayOrder = 2;
channel.ValidationRules = new List<ValidationRuleElement> { new ValidationRuleElement() { Name = "NotNullOrEmpty" } };
channel.ChoiceList = new List<ValueType>
{
    new ValueType() { StringValue = "1" },
    new ValueType() { StringValue = "2" },
    new ValueType() { StringValue = "3" },
    new ValueType() { StringValue = "4" },
    new ValueType() { StringValue = "5" },
    new ValueType() { StringValue = "6" },
    new ValueType() { StringValue = "7" },
    new ValueType() { StringValue = "8" }
};
channel.Value = new ValueType();
channel.Value.StringValue = "1";
etsPositionerParameters.Properties.Add(channel);

string output = JsonConvert.SerializeObject(parameters, Formatting.Indented);

var obj = JsonConvert.DeserializeObject<Parameters>(output);

if (obj != null)
{
    string? emCenterSlot = obj.GetPropertyAsString("ETS-Lindgren 3-Axis Positioner.Slot");
}

Console.WriteLine(output);

