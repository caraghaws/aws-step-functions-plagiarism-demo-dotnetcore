using System;
using Amazon.Lambda.Core;
using Amazon.XRay.Recorder.Handlers.AwsSdk;

// Assembly attribute to enable the Lambda function's JSON state to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace SubmitExamTask
{
    public class Function
    {
        public Function()
        {
            AWSSDKHandler.RegisterXRayForAllServices();
        }

        /// <summary>
        /// Function to pass callback to state machine.
        /// </summary>
        /// <param name="eid"></param>
        /// <param name="iid"></param>
        /// <param name="score"></param>
        /// <param name="tt"></param>              
        /// <returns></returns>
        public State FunctionHandler(State state, ILambdaContext context)
        {
            // TODO translate python to DotNet (see ./SubmitExamTaskPy.py file) or...

            /*
                import json
                import boto3

                client = boto3.client('stepfunctions')

                def lambda_handler(event, context):
                    
                    payload = json.dumps(event)
                    examId = event['eid']
                    print('examId: ', examId)

                    incidentId = event['iid']
                    print('incidentId: ', incidentId)

                    score = event['score']
                    print('score: ', score)
                    
                    taskToken = event['tt']
                    print('taskToken: ', taskToken) 
                    
                    output = [];
                    output.append({'eid': examId, 'iid' : incidentId, 'score' : score})

                    response = client.send_task_success(
                        taskToken=taskToken,
                        output=json.dumps(output)
                    )
                    
                    return {
                        'statusCode': 200,
                        'body': json.dumps(output),
                        'headers': {
                            'Content-Type': 'application/json',
                            'Access-Control-Allow-Origin': '*'
                        },
                    }
            */
        }
    }
}
