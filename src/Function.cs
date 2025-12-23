using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace HelloLambda
{
    public class Function
    {
        private int Count {get; set;}
        public string FunctionHandler()
        {
            Count++;
            return "Hello from Lambda v1";
        }
    }
}
