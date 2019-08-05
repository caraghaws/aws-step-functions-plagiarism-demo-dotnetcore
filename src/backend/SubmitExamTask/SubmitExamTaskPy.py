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
	

	
    response = client.send_task_success(
        taskToken=taskToken,
        output='string'
    )
    
    
    return {
        'statusCode': 200,
        'body': json.dumps(response)
    }
