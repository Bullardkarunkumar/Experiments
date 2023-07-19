using Grpc.Core;

namespace ETSGrpcSwitch.Services
{
    public class TemSwitchService:TemSwitch.TemSwitchBase
    {
        private readonly ILogger<TemSwitchService> _logger;     


        public TemSwitchService(ILogger<TemSwitchService> logger)
        {
            _logger = logger;
        }
        public TemSwitchService() { }

        public override Task<TModuleInfoValues> GetModuleTypeInfo(NullValue request, ServerCallContext context)
        {
            return base.GetModuleTypeInfo(request, context);
        }

        public override Task<NullValue> DoOnFirstInit(NullValue request, ServerCallContext context)
        {
            return base.DoOnFirstInit(request, context);
        }
        public override Task<IntValue> CheckInterlock(NullValue request, ServerCallContext context)
        {
            return base.CheckInterlock(request, context);
        }       

        public override Task<NullValue> GetStateVector(NullValue request, ServerCallContext context)
        {
            return base.GetStateVector(request, context);
        }
       
        public override Task<NullValue> SetStateVector(ArrayWithNotSupportedTypes request, ServerCallContext context)
        {
            return base.SetStateVector(request, context);
        }       
    }
}


