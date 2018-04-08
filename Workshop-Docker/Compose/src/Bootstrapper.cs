using FP.MdDevDays2018.MongoMessage.Data;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;

namespace FP.MdDevDays2018.MongoMessage
{
     public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            
            container.Register(new MessageRepository("mongodb://messagedb"));
            base.ApplicationStartup(container, pipelines);
        }

        public override void Configure(Nancy.Configuration.INancyEnvironment environment)
        {
            environment.Tracing(enabled: false, displayErrorTraces: true);
        }
    }
}