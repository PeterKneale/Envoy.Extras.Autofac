using Autofac;

namespace Envoy.Extras.Autofac
{
    public class EnvoyAutofacModule : Module
    {
        private bool _tracing = false;

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Dispatcher>()
                   .As<IDispatchCommands>()
                   .As<IDispatchEvents>()
                   .As<IDispatchRequests>();

            builder.RegisterType<Executor>()
                .As<IExecuteCommands>()
                .As<IExecuteEvents>()
                .As<IExecuteRequests>();

            builder.RegisterType<TraceLogger>()
                .As<ILogger>()
                .OnlyIf(x => _tracing);
            builder.RegisterType<NullLogger>()
                .As<ILogger>()
                .OnlyIf(x => !_tracing);

            // Register a container adaptor of choice
            builder.RegisterType<EnvoyAutofacResolver>()
                .As<IResolver>();
        }

        public bool EnableTracing { set { _tracing = true; } }
    }
}
