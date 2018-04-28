using Autofac;
using Xunit;

namespace Envoy.Extras.Autofac.Tests
{
    public class EnvoyAutofacModuleTests
    {
        private IContainer _container;

        public EnvoyAutofacModuleTests()
        {
            var builder = new ContainerBuilder();
            builder.RegisterEnvoy();
            builder.RegisterEnvoyHandlers(typeof(EnvoyAutofacModuleTests).Assembly);
            _container = builder.Build();
        }

        [Fact]
        public void Command_dispatcher_can_be_resolved()
        {
            Assert.NotNull(_container.Resolve<IDispatchCommands>());
        }

        [Fact]
        public void Request_dispatcher_can_be_resolved()
        {
            Assert.NotNull(_container.Resolve<IDispatchRequests>());
        }

        [Fact]
        public void Event_dispatcher_can_be_resolved()
        {
            Assert.NotNull(_container.Resolve<IDispatchEvents>());
        }

        [Fact]
        public void Resolver_can_be_resolved()
        {
            Assert.NotNull(_container.Resolve<IResolver>());
        }

        [Fact]
        public void Logger_can_be_resolved()
        {
            Assert.NotNull(_container.Resolve<ILogger>());
        }

        [Fact]
        public void Command_handler_can_be_resolved()
        {
            Assert.NotNull(_container.Resolve<IHandleCommand<TestCommand>>());
        }

        [Fact]
        public void Request_handler_can_be_resolved()
        {
            Assert.NotNull(_container.Resolve<IHandleRequest<TestRequest, TestResponse>>());
        }

        [Fact]
        public void Event_handler_can_be_resolved()
        {
            Assert.NotNull(_container.Resolve<IHandleEvent<TestEvent>>());
        }
    }
}


