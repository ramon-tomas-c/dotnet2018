using Autofac;

public class ApplicationModule : Module
{

    public ApplicationModule()
    {
    }

    protected override void Load(ContainerBuilder builder)
    {

        builder.RegisterType<BeersContext>()
            .InstancePerLifetimeScope();

        builder.RegisterType<BeersDBInitializer>()
                .InstancePerLifetimeScope();
    }
}