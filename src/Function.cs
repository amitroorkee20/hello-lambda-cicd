using System;
using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace HelloLambda
{
  public class Function
  {
    public string FunctionHandler(object input, ILambdaContext context)
    {
      context.Logger.LogLine("HelloLambda invoked successfully 🚀");
      return "Hello from CI/CD + CloudWatch";
    }
  }
}
