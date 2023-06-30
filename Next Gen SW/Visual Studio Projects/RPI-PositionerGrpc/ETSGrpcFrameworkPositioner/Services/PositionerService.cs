using Grpc.Core;
using PosGrpcService;
using ETSGrpcPositioner.Positioner;
using ETS.EMQuest.Modules.SimulatedPositioner;
using Ets.Instrument;
using static Ets.Instrument.Axis;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace PosGrpcService.Services
{
    public class PositionerService : Positioner.PositionerBase
    {
        private readonly ILogger<PositionerService> _logger;
        private Axis _positioner;
        private Configuration _config;

        public PositionerService(ILogger<PositionerService> logger)
        {
            _logger = logger;
            _positioner = new SimulatedPositioner();
            _config = new Configuration();
        }

        public PositionerService()
        {
            _positioner = new SimulatedPositioner();
            _config = new Configuration();
        }

        // Server side handler of the GetConfiguration RPC
        public override Task<Configuration> GetConfiguration(NullValue value, ServerCallContext context)
        {
            Configuration config = new Configuration();
            return Task.FromResult(_config);
        }

        public override Task<BoolValue> SetConfiguration(Configuration config, ServerCallContext context)
        {
            BoolValue status = new BoolValue();
            _config = config;

            _positioner.CreateConnection(new Device("ETSPositioner", string.Empty, _config.VisaConnectString));
            _positioner.SetDevice(config.VisaConnectString);
            var axisSpecificProps = _positioner.AxisSpecificProperties as ETSPositionerSpecificProperties;
            if (axisSpecificProps != null)
            {
                axisSpecificProps.InitParams(config.AxisSpecificProperties);
            }

            status.Value = _positioner.ConnectToDevice(config.VisaConnectString);

            _positioner.UpperLimit = config.UpperLimit;
            _positioner.LowerLimit = config.LowerLimit;
            _positioner.SetSpeedSettingPercent(1,config.SpeedSetting1);
            _positioner.SetSpeedSettingPercent(2, config.SpeedSetting2);
            _positioner.SetSpeedSettingPercent(3, config.SpeedSetting3);
            _positioner.SetSpeedSettingPercent(4, config.SpeedSetting4);
            _positioner.SetSpeedSettingPercent(5, config.SpeedSetting5);
            _positioner.SetSpeedSettingPercent(6, config.SpeedSetting6);
            _positioner.SetSpeedSettingPercent(7, config.SpeedSetting7);
            _positioner.SetSpeedSettingPercent(8, config.SpeedSetting8);

            return Task.FromResult<BoolValue>(status);
        }

        public override Task<IntValue> GetRotationMode(NullValue value, ServerCallContext context)
        {
            IntValue mode = new IntValue();
            mode.Value = (int)_positioner.RotationMode;
            return Task.FromResult<IntValue>(mode);
        }

        public override Task<NullValue> SetRotationMode(IntValue value, ServerCallContext context)
        {
            NullValue retVal = new NullValue();
            _positioner.RotationMode = (AxisRotation)value.Value;
            return Task.FromResult<NullValue>(retVal);
        }

        public override Task<DoubleValue> GetCP(NullValue request, ServerCallContext context)
        {
            DoubleValue position = new DoubleValue();
            position.Value = _positioner.CurrentPosition; 
            return Task.FromResult<DoubleValue>(position); 
        }

        public override Task<NullValue> SetCP(DoubleValue request, ServerCallContext context)
        {
            NullValue retVal = new NullValue();
            _positioner.CurrentPosition = request.Value;    
            return Task.FromResult<NullValue>(retVal);
        }

        public override Task<DoubleValue> GetTargetPosition(NullValue request, ServerCallContext context)
        {
            DoubleValue position = new DoubleValue();
            position.Value = _positioner.TargetPosition;
            return Task.FromResult<DoubleValue>(position);
        }

        public override Task<NullValue> SetTargetPosition(DoubleValue request, ServerCallContext context)
        {
            NullValue retVal = new NullValue();
            _positioner.TargetPosition = request.Value;
            return Task.FromResult<NullValue>(retVal);
        }

        public override Task<DoubleValue> GetCWLimit(NullValue request, ServerCallContext context)
        {
            DoubleValue limit = new DoubleValue();
            limit.Value = _positioner.CwLimit;
            return Task.FromResult<DoubleValue>(limit);
        }

        public override Task<NullValue> SetCWLimit(DoubleValue request, ServerCallContext context)
        {
            NullValue retVal = new NullValue();
            _positioner.CwLimit = request.Value;
            return Task.FromResult<NullValue>(retVal);
        }

        public override Task<DoubleValue> GetCCWLimit(NullValue request, ServerCallContext context)
        {
            DoubleValue limit = new DoubleValue();
            limit.Value = _positioner.CcwLimit;
            return Task.FromResult<DoubleValue>(limit);
        }

        public override Task<NullValue> SetCCWLimit(DoubleValue request, ServerCallContext context)
        {
            NullValue retVal = new NullValue();
            _positioner.CcwLimit = request.Value;
            return Task.FromResult<NullValue>(retVal);
        }

        public override Task<DoubleValue> GetAccelerationInMS(NullValue request, ServerCallContext context)
        {
            DoubleValue acc = new DoubleValue();
            acc.Value = _positioner.AccelerationInMS;
            return Task.FromResult<DoubleValue>(acc);
        }

        public override Task<NullValue> SetAccelerationInMS(DoubleValue request, ServerCallContext context)
        {
            NullValue retVal = new NullValue();
            _positioner.AccelerationInMS = request.Value;
            return Task.FromResult<NullValue>(retVal);
        }

        public override Task<DoubleValue> GetScanCycles(NullValue request, ServerCallContext context)
        {
            DoubleValue cycles = new DoubleValue();
            cycles.Value = _positioner.ScanCycles;
            return Task.FromResult<DoubleValue>(cycles);
        }
         
        public override Task<NullValue> SetScanCycles(DoubleValue request, ServerCallContext context)
        {
            NullValue retVal = new NullValue();
            _positioner.ScanCycles = request.Value;
            return Task.FromResult<NullValue>(retVal);
        }

        public override Task<IntValue> GetCurrentSpeed(NullValue request, ServerCallContext context)
        {
            IntValue speed = new IntValue();
            speed.Value = _positioner.CurrentSpeed;
            return Task.FromResult<IntValue>(speed);
        }

        public override Task<NullValue> SetCurrentSpeed(IntValue request, ServerCallContext context)
        {
            NullValue retVal = new NullValue();
            _positioner.CurrentSpeed = request.Value;
            return Task.FromResult<NullValue>(retVal);
        }

        public override Task<DoubleValue> GetCurrentVelocity(NullValue request, ServerCallContext context)
        {
            DoubleValue vel = new DoubleValue();
            vel.Value = _positioner.Velocity;
            return Task.FromResult<DoubleValue>(vel);
        }

        public override Task<NullValue> SetCurrentVelocity(DoubleValue request, ServerCallContext context)
        {
            NullValue retVal = new NullValue();
            _positioner.CurrentVelocity = request.Value;
            return Task.FromResult<NullValue>(retVal);
        }

        public override Task<BoolValue> OperationComplete(NullValue request, ServerCallContext context)
        {
            BoolValue status = new BoolValue();
            status.Value = true;
            return Task.FromResult<BoolValue>(status);
        }

        public override Task<StringValue> Seek(DoubleValue request, ServerCallContext context)
        {
            StringValue commandResponse = new StringValue();
            commandResponse.Value = _positioner.Seek(request.Value);
            return Task.FromResult<StringValue>(commandResponse);
        }
        public override Task<StringValue> SeekPositive(DoubleValue request, ServerCallContext context)
        {
            StringValue commandResponse = new StringValue();
            commandResponse.Value = _positioner.SeekPositive(request.Value);
            return Task.FromResult<StringValue>(commandResponse);
        }
        public override Task<StringValue> SeekNegative(DoubleValue request, ServerCallContext context)
        {
            StringValue commandResponse = new StringValue();
            commandResponse.Value = _positioner.SeekNegative(request.Value);
            return Task.FromResult<StringValue>(commandResponse);
        }
        public override Task<StringValue> Clockwise(NullValue request, ServerCallContext context)
        {
            StringValue commandResponse = new StringValue();
            commandResponse.Value = _positioner.Clockwise();
            return Task.FromResult<StringValue>(commandResponse);
        }
        public override Task<StringValue> CounterClockwise(NullValue request, ServerCallContext context)
        {
            StringValue commandResponse = new StringValue();
            commandResponse.Value = _positioner.CounterClockwise();
            return Task.FromResult<StringValue>(commandResponse);
        }
        public override Task<StringValue> Stop(NullValue request, ServerCallContext context)
        {
            StringValue commandResponse = new StringValue();
            commandResponse.Value = _positioner.Stop();
            return Task.FromResult<StringValue>(commandResponse);
        }

        public override Task<StringValue> Scan(NullValue request, ServerCallContext context)
        {
            StringValue commandResponse = new StringValue();
            commandResponse.Value = _positioner.Scan();
            return Task.FromResult<StringValue>(commandResponse);
        }
        public override Task<BoolValue> Home(NullValue request, ServerCallContext context)
        {
            BoolValue commandResponse = new BoolValue();
            commandResponse.Value = _positioner.Home();
            return Task.FromResult<BoolValue>(commandResponse);
        }

        public override Task<BoolValue> IsHomed(NullValue request, ServerCallContext context)
        {
            BoolValue commandResponse = new BoolValue();
            commandResponse.Value = _positioner.IsHomed;
            return Task.FromResult<BoolValue>(commandResponse);
        }

        public override Task<NullValue> SetSpeedSettingPercent(SpeedSettingValue request, ServerCallContext context)
        {
            StringValue commandResponse = new StringValue();
            _positioner.SetSpeedSettingPercent(request.Setting, request.Value);
            return Task.FromResult(new NullValue());
        }
        public override Task<NullValue> ClearDeviceError(NullValue request, ServerCallContext context)
        { 
            _positioner.ClearDeviceError();
            return Task.FromResult(new NullValue());
        }
        public override Task<StringValue> GetDeviceError(NullValue request, ServerCallContext context)
        {
            StringValue commandResponse = new StringValue();
            commandResponse.Value = _positioner.GetDeviceError();
            return Task.FromResult<StringValue>(commandResponse);
        }
        public override Task<StringValue> GetIDN(NullValue request, ServerCallContext context)
        {
            StringValue commandResponse = new StringValue();
            commandResponse.Value = _positioner.GetIDN();
            return Task.FromResult<StringValue>(commandResponse);
        }
    }
}