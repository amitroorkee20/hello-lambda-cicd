using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace HelloLambda
{
    public class Function
    {
        public string FunctionHandler()
        {
            return "Hello from Lambda v1";
        }
    }
}
