using Ets.Instrument;
using ETSGrpcPositioner.Positioner;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Ets.Instrument.Axis;

namespace PosGrpcService.Services
{
    public class PositionerService : Positioner.PositionerBase
    {
        private readonly ILogger<PositionerService> _logger;
        private Dictionary<string, Axis> positioners = new Dictionary<string, Axis>();
        private Dictionary<string, Configuration> configurations = new Dictionary<string, Configuration>();

        public PositionerService(ILogger<PositionerService> logger)
        {
            _logger = logger;
        }

        public PositionerService()
        {
        }

        // Server side handler of the GetConfiguration RPC
        public override Task<Configuration> GetConfiguration(NullValue value, ServerCallContext context)
        {
            Configuration config;
            if (!configurations.TryGetValue(value.SessionId, out config))
            {
                config = new Configuration();
            }
            return Task.FromResult(config);
        }

        public override Task<BoolValue> SetConfiguration(Configuration config, ServerCallContext context)
        {
            
            BoolValue status = new BoolValue();
            status.SessionId = config.SessionId;

            Configuration configuration;
            if (configurations.TryGetValue(config.SessionId, out configuration))
            {
                configurations.Remove(config.SessionId);
            }

            configurations.Add(config.SessionId, config);

            Axis positioner;
            if (positioners.TryGetValue(config.SessionId, out positioner))
            {
                positioners.Remove(config.SessionId);
                positioner.PosConnection.CloseConnection();
            }

            positioner = new ETSPositioner();
            positioners.Add(config.SessionId, positioner);

            var axisSpecificProps = positioner.AxisSpecificProperties as ETSPositionerSpecificProperties;
            if (axisSpecificProps != null)
            {
                axisSpecificProps.InitParams(config.AxisSpecificProperties);
            }

            positioner.CreateConnection(new Device("ETSPositioner", string.Empty, config.VisaConnectString));
            positioner.SetDevice(config.VisaConnectString);

            status.Value = positioner.ConnectToDevice(config.VisaConnectString);

            positioner.UpperLimit = config.UpperLimit;
            positioner.LowerLimit = config.LowerLimit;
            positioner.SetSpeedSettingPercent(1,config.SpeedSetting1);
            positioner.SetSpeedSettingPercent(2, config.SpeedSetting2);
            positioner.SetSpeedSettingPercent(3, config.SpeedSetting3);
            positioner.SetSpeedSettingPercent(4, config.SpeedSetting4);
            positioner.SetSpeedSettingPercent(5, config.SpeedSetting5);
            positioner.SetSpeedSettingPercent(6, config.SpeedSetting6);
            positioner.SetSpeedSettingPercent(7, config.SpeedSetting7);
            positioner.SetSpeedSettingPercent(8, config.SpeedSetting8);

            return Task.FromResult<BoolValue>(status);
        }

        public override Task<IntValue> GetRotationMode(NullValue value, ServerCallContext context)
        {
            IntValue mode = new IntValue();
            mode.SessionId = string.Empty;
            
            Axis positioner;
            if (positioners.TryGetValue(value.SessionId, out positioner))
            {
                mode.Value = (int)positioner.RotationMode;
                mode.SessionId = value.SessionId;
            }
            return Task.FromResult<IntValue>(mode);
        }

        public override Task<NullValue> SetRotationMode(IntValue value, ServerCallContext context)
        {
            NullValue retVal = new NullValue();
            retVal.SessionId = string.Empty;

            Axis positioner;
            if (positioners.TryGetValue(value.SessionId, out positioner))
            {
                positioner.RotationMode = (AxisRotation)value.Value;
                retVal.SessionId = value.SessionId;
            }

            return Task.FromResult<NullValue>(retVal);
        }

        public override Task<DoubleValue> GetCP(NullValue request, ServerCallContext context)
        {
            DoubleValue position = new DoubleValue();
            position.SessionId = string.Empty;

            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                position.Value = positioner.CurrentPosition;
                position.SessionId = request.SessionId;
            }

            return Task.FromResult<DoubleValue>(position); 
        }

        public override Task<NullValue> SetCP(DoubleValue request, ServerCallContext context)
        {
            NullValue retVal = new NullValue();
            retVal.SessionId = string.Empty;

            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                positioner.CurrentPosition = request.Value;
                retVal.SessionId = request.SessionId;
            }

            return Task.FromResult<NullValue>(retVal);
        }

        public override Task<DoubleValue> GetTargetPosition(NullValue request, ServerCallContext context)
        {
            DoubleValue position = new DoubleValue();
            position.SessionId = string.Empty;

            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                position.Value = positioner.TargetPosition;
                position.SessionId = request.SessionId; 
            }

            return Task.FromResult<DoubleValue>(position);
        }

        public override Task<NullValue> SetTargetPosition(DoubleValue request, ServerCallContext context)
        {
            NullValue retVal = new NullValue();
            retVal.SessionId = string.Empty;

            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                positioner.TargetPosition = request.Value;
                retVal.SessionId = request.SessionId;
            }

            return Task.FromResult<NullValue>(retVal);
        }

        public override Task<DoubleValue> GetCWLimit(NullValue request, ServerCallContext context)
        {
            DoubleValue limit = new DoubleValue();
            limit.SessionId = string.Empty;

            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                limit.Value = positioner.CwLimit;
                limit.SessionId = request.SessionId;
            }

            return Task.FromResult<DoubleValue>(limit);
        }

        public override Task<NullValue> SetCWLimit(DoubleValue request, ServerCallContext context)
        {
            NullValue retVal = new NullValue();
            retVal.SessionId= string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                positioner.CwLimit = request.Value;
                retVal.SessionId = request.SessionId;
            }

            return Task.FromResult<NullValue>(retVal);
        }

        public override Task<DoubleValue> GetCCWLimit(NullValue request, ServerCallContext context)
        {
            DoubleValue limit = new DoubleValue();
            limit.SessionId = string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                limit.Value = positioner.CcwLimit;
                limit.SessionId = request.SessionId;
            }

            return Task.FromResult<DoubleValue>(limit);
        }

        public override Task<NullValue> SetCCWLimit(DoubleValue request, ServerCallContext context)
        {
            NullValue retVal = new NullValue();
            retVal.SessionId= string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                positioner.CcwLimit = request.Value;
                retVal.SessionId = request.SessionId;
            }

            return Task.FromResult<NullValue>(retVal);
        }

        public override Task<DoubleValue> GetAccelerationInMS(NullValue request, ServerCallContext context)
        {
            DoubleValue acc = new DoubleValue();
            acc.SessionId = string.Empty;

            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                acc.Value = positioner.AccelerationInMS;
                acc.SessionId = request.SessionId;
            }

            return Task.FromResult<DoubleValue>(acc);
        }

        public override Task<NullValue> SetAccelerationInMS(DoubleValue request, ServerCallContext context)
        {
            NullValue retVal = new NullValue();
            retVal.SessionId= string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                positioner.AccelerationInMS = request.Value;
                retVal.SessionId = request.SessionId;
            }

            return Task.FromResult<NullValue>(retVal);
        }

        public override Task<DoubleValue> GetScanCycles(NullValue request, ServerCallContext context)
        {
            DoubleValue cycles = new DoubleValue();
            cycles.SessionId = string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                cycles.Value = positioner.ScanCycles;
                cycles.SessionId = request.SessionId;
            }

            return Task.FromResult<DoubleValue>(cycles);
        }
         
        public override Task<NullValue> SetScanCycles(DoubleValue request, ServerCallContext context)
        {
            NullValue retVal = new NullValue();
            retVal.SessionId= string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                positioner.ScanCycles = request.Value;
                retVal.SessionId = request.SessionId;
            }

            return Task.FromResult<NullValue>(retVal);
        }

        public override Task<IntValue> GetCurrentSpeed(NullValue request, ServerCallContext context)
        {
            IntValue speed = new IntValue();
            speed.SessionId = string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                speed.Value = positioner.CurrentSpeed;
                speed.SessionId = request.SessionId;
            }

            return Task.FromResult<IntValue>(speed);
        }

        public override Task<NullValue> SetCurrentSpeed(IntValue request, ServerCallContext context)
        {
            NullValue retVal = new NullValue();
            retVal.SessionId = string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                positioner.CurrentSpeed = request.Value;
                retVal.SessionId = request.SessionId;
            }

            return Task.FromResult<NullValue>(retVal);
        }

        public override Task<DoubleValue> GetCurrentVelocity(NullValue request, ServerCallContext context)
        {
            DoubleValue vel = new DoubleValue();
            vel.SessionId = string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                vel.Value = positioner.Velocity;
                vel.SessionId = request.SessionId;
            }

            return Task.FromResult<DoubleValue>(vel);
        }

        public override Task<NullValue> SetCurrentVelocity(DoubleValue request, ServerCallContext context)
        {
            NullValue retVal = new NullValue();
            retVal.SessionId = string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                positioner.CurrentVelocity = request.Value;
                retVal.SessionId = request.SessionId;
            }

            return Task.FromResult<NullValue>(retVal);
        }

        public override Task<BoolValue> OperationComplete(NullValue request, ServerCallContext context)
        {
            BoolValue status = new BoolValue();
            status.SessionId = string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                status.Value = true;
                status.SessionId = request.SessionId;
            }

            return Task.FromResult<BoolValue>(status);
        }

        public override Task<StringValue> Seek(DoubleValue request, ServerCallContext context)
        {
            StringValue commandResponse = new StringValue();
            commandResponse.SessionId = string.Empty;

            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                commandResponse.Value = positioner.Seek(request.Value);
                commandResponse.SessionId = request.SessionId;
            }

            return Task.FromResult<StringValue>(commandResponse);
        }
        public override Task<StringValue> SeekPositive(DoubleValue request, ServerCallContext context)
        {
            StringValue commandResponse = new StringValue();
            commandResponse.SessionId = string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                commandResponse.Value = positioner.SeekPositive(request.Value);
                commandResponse.SessionId = request.SessionId;
            }

            return Task.FromResult<StringValue>(commandResponse);
        }
        public override Task<StringValue> SeekNegative(DoubleValue request, ServerCallContext context)
        {
            StringValue commandResponse = new StringValue();
            commandResponse.SessionId = string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                commandResponse.Value = positioner.SeekNegative(request.Value);
                commandResponse.SessionId = request.SessionId;
            }

            return Task.FromResult<StringValue>(commandResponse);
        }
        public override Task<StringValue> Clockwise(NullValue request, ServerCallContext context)
        {
            StringValue commandResponse = new StringValue();
            commandResponse.SessionId = string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                commandResponse.Value = positioner.Clockwise();
                commandResponse.SessionId = request.SessionId;
            }

            return Task.FromResult<StringValue>(commandResponse);
        }

        public override Task<StringValue> CounterClockwise(NullValue request, ServerCallContext context)
        {
            StringValue commandResponse = new StringValue();
            commandResponse.SessionId = string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                commandResponse.Value = positioner.CounterClockwise();
                commandResponse.SessionId = request.SessionId;
            }

            return Task.FromResult<StringValue>(commandResponse);
        }
        public override Task<StringValue> Stop(NullValue request, ServerCallContext context)
        {
            StringValue commandResponse = new StringValue();
            commandResponse.SessionId = string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                commandResponse.Value = positioner.Stop();
                commandResponse.SessionId = request.SessionId;
            }

            return Task.FromResult<StringValue>(commandResponse);
        }

        public override Task<StringValue> Scan(NullValue request, ServerCallContext context)
        {
            StringValue commandResponse = new StringValue();
            commandResponse.SessionId = string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                commandResponse.Value = positioner.Scan();
                commandResponse.SessionId = request.SessionId;
            }

            return Task.FromResult<StringValue>(commandResponse);
        }
        public override Task<BoolValue> Home(NullValue request, ServerCallContext context)
        {
            BoolValue commandResponse = new BoolValue();
            commandResponse.SessionId = string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                commandResponse.Value = positioner.Home();
                commandResponse.SessionId = request.SessionId;
            }

            return Task.FromResult<BoolValue>(commandResponse);
        }

        public override Task<BoolValue> IsHomed(NullValue request, ServerCallContext context)
        {
            BoolValue commandResponse = new BoolValue();
            commandResponse.SessionId = string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                commandResponse.Value = positioner.IsHomed;
                commandResponse.SessionId = request.SessionId;
            }

            return Task.FromResult<BoolValue>(commandResponse);
        }

        public override Task<NullValue> SetSpeedSettingPercent(SpeedSettingValue request, ServerCallContext context)
        {
            StringValue commandResponse = new StringValue();
            commandResponse.SessionId = string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                positioner.SetSpeedSettingPercent(request.Setting, request.Value);
                commandResponse.SessionId = request.SessionId;
            }

            return Task.FromResult(new NullValue());
        }
        public override Task<NullValue> ClearDeviceError(NullValue request, ServerCallContext context)
        { 
            NullValue retVal = new NullValue();
            retVal.SessionId = string.Empty;

            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                positioner.ClearDeviceError();
                retVal.SessionId = request.SessionId;
            }
            
            return Task.FromResult(retVal);
        }

        public override Task<StringValue> GetDeviceError(NullValue request, ServerCallContext context)
        {
            StringValue commandResponse = new StringValue();
            commandResponse.SessionId = string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                commandResponse.Value = positioner.GetDeviceError();
                commandResponse.SessionId = request.SessionId;
            }

            return Task.FromResult<StringValue>(commandResponse);
        }

        public override Task<StringValue> GetIDN(NullValue request, ServerCallContext context)
        {
            StringValue commandResponse = new StringValue();
            commandResponse.SessionId = string.Empty;
            Axis positioner;
            if (positioners.TryGetValue(request.SessionId, out positioner))
            {
                commandResponse.Value = positioner.GetIDN();
                commandResponse.SessionId = request.SessionId;
            }

            return Task.FromResult<StringValue>(commandResponse);
        }
    }
}