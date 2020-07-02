# CSharpExamples
This is a generatl example project.  All you have to do to test your example is go to the main metho dof the 
program.cs file and change the line that creates the for that you want to test. 

```
static void Main() {
    Application.SetHighDpiMode(HighDpiMode.SystemAware);
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);
    Application.Run(new MathExpressionExample());
}
```



# SimpleService and Host projects
These projects come from https://www.youtube.com/watch?v=EWBgqfhAT9U&t=6s
youtube video.  The code is in the comments section.


# Wcf Services
To use a wcf service, you need to configure it first.  In this example, we have both options
but if you want to test the fluent one, you must comment the app.config file and if you
want to test the config file, make sure you have the configuration shown in the section below.

## Config files
There are 2 config setting when you use the file configuration method and not the Fluent Method
which uses code to do the configuration.  In this example, to test the fluent method, comments the 
section in both config files that are under <system.serviceModel>

Note that you can configure the client with config file and the server in fluent and vice versa.
### Server side

app.config
```
  <system.serviceModel>
    <behaviors>
      <serviceBehaviors>
        <behavior name="mexBehavior">
          <serviceMetadata httpGetEnabled="true" />
        </behavior>
      </serviceBehaviors>
    </behaviors>
    <services>
      <service behaviorConfiguration="mexBehavior" name="SimpleService.SimpleService">
        <endpoint address="SimpleService"
                  binding="wsHttpBinding"
                  contract="SimpleService.ISimpleService"/>
        <host>
          <baseAddresses>
            <add baseAddress="http://localhost:8080" />
          </baseAddresses>
        </host>
      </service>
    </services>
  </system.serviceModel>
```
### Client side
app.config
```
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.5.2" />
    </startup>
    <system.serviceModel>
        <bindings>
            <wsHttpBinding>
                <binding name="WSHttpBinding_ISimpleService" />
            </wsHttpBinding>
        </bindings>
        <client>
            <endpoint address="http://localhost:8080/SimpleService" binding="wsHttpBinding"
                bindingConfiguration="WSHttpBinding_ISimpleService" contract="SimpleService.ISimpleService"
                name="WSHttpBinding_ISimpleService">
                <identity>
                    <userPrincipalName value="JORGE-LENOVO\jorge" />
                </identity>
            </endpoint>
        </client>
    </system.serviceModel>
</configuration>
```