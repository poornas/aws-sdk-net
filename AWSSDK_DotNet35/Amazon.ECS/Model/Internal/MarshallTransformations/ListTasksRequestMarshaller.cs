/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListTasks Request Marshaller
    /// </summary>       
    public class ListTasksRequestMarshaller : IMarshaller<IRequest, ListTasksRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListTasksRequest)input);
        }

        public IRequest Marshall(ListTasksRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ECS");
            string target = "AmazonEC2ContainerServiceV20141113.ListTasks";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCluster())
                {
                    context.Writer.WritePropertyName("cluster");
                    context.Writer.Write(publicRequest.Cluster);
                }

                if(publicRequest.IsSetContainerInstance())
                {
                    context.Writer.WritePropertyName("containerInstance");
                    context.Writer.Write(publicRequest.ContainerInstance);
                }

                if(publicRequest.IsSetFamily())
                {
                    context.Writer.WritePropertyName("family");
                    context.Writer.Write(publicRequest.Family);
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("maxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("nextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetServiceName())
                {
                    context.Writer.WritePropertyName("serviceName");
                    context.Writer.Write(publicRequest.ServiceName);
                }

                if(publicRequest.IsSetStartedBy())
                {
                    context.Writer.WritePropertyName("startedBy");
                    context.Writer.Write(publicRequest.StartedBy);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}